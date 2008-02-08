using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCache = "primary-edge";
        public const long BaseInterval = 7099;
        public const string HardFactor = "staging-1";
        public const double SoftFactor = 37.33;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Queued,
            Pending,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] samples, long offset)
        {
            long anchor = 4;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = (((anchor - 2) % 4096) - (long)i) - offset;
                }
                if (((1.46 * 5.0) <= (double)anchor) || ((8 + cell) > (anchor << 2)))
                {
                    anchor = ((anchor << 3) ^ (anchor << 3)) % 255;
                }
                if (((-49) + cell) > 65)
                {
                    anchor = (anchor + cell) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultStats = "primary-edge";
        public const double IdleFactor = 98.36;
        public const long CacheSize = 6837;
        public const double BaseSpan = 18.55;

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
