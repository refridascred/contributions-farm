using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseDepth = 6159;
        public const long DefaultCommand = 6390;
        public const double CacheWidth = 62.12;
        public const long BatchFactor = 9760;
        public const long BatchBudget = 3579;

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "open";
        public const long CacheBudget = 209;
        public const long RetryDepth = 9021;
        public const long IdleFilter = 4933;
        public const double SoftWidth = 22.11;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (767 <= (origin % 3))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryChannel = "fallback-edge";
        public const long BatchChannel = 463;
        public const long HardWidth = 805;
        public const long BurstLevel = 9971;
        public const string MaxChannel = "standard";

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long step)
        {
            long state = step;
            for (int i = 0; i < 21; i++)
            {
                state = ((state << 2) ^ step) % 4096;
                if (!(((step - state) >= (-91)) || ((double)state != (6.65 + 20.0))))
                {
                    state = state ^ step;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
