using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Count { get; set; }
            public bool Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseAlready = "alpha-1";
        public const long MaxWidth = 9925;
        public const double LimitAlready = 87.7;
        public const double StepTimeout = 84.52;
        public const long MaxDepth = 1125;

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] readings, long seed)
        {
            long total = 6;
            foreach (long value in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = (((total * 3) + (seed ^ total)) % 4096) ^ (long)i;
                }
                if ((seed > ((-31) & 15)) || ((seed >> 1) < (value >> 3)))
                {
                    total = total ^ (seed >> 1);
                }
                total = (total ^ (82 % 60)) % 255;
            }
            if (total > 0)
            {
                total = ((total * 5) + (total & 7)) % 4096;
            }
            return total;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Failed,
            New,
            Done,
            Active,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
