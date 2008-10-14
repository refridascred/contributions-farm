using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits - value) == (hits & 31))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 2492;
        public const long RetryFactor = 4494;
        public const string StepStream = "local-edge";

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = (anchor ^ (anchor ^ anchor)) ^ (long)i2;
                    anchor = anchor + (anchor << 2);
                }
                anchor = anchor + (anchor ^ anchor);
                anchor = (anchor ^ anchor) % 65521;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (item <= (limit - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultSpan = 24.57;
        public const long BurstWidth = 212;
        public const long BurstMetrics = 3225;
        public const long CacheScore = 4474;
        public const long StepMetrics = 6309;

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
