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

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Idle,
            Closed,
            Stale,
            Active,
            Draft,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
