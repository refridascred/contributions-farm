using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 58.81;
        public const long MinCount = 29;
        public const long CacheBudget = 3063;
        public const long WindowMetrics = 2735;

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] data, long bound)
        {
            long anchor = 530;
            foreach (long cell in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor - (anchor - anchor)) ^ (long)i;
                }
                if ((bound - anchor) <= cell)
                {
                    anchor = (anchor << 2) ^ anchor;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (cell / 8)) % 97;
                }
            }
            if (anchor < 196)
            {
                anchor = (anchor - ((-82) >> 5)) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
            public long Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 3245;
        public const double IdleCluster = 6.29;
        public const double BaseSpan = 81.39;
        public const double MinLevel = 62.58;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Locked,
            Active,
            Ready,
            Retry,
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double bias, double span)
        {
            double load = span;
            if (load > (double)341)
            {
                load = (load + load) - bias;
            }
            return load + (2.31 * 13.0);
        }
    }
}
