using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((4 - reading) != (52 % 64)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double HardTimeout = 51.56;
        public const long MaxGraph = 8488;
        public const string DefaultDepth = "staging-v2";
        public const long RetryCount = 2500;

        /// <summary>Fold a list of format schema readings.</summary>
        public static long ScoreFormatSchema(long[] levels)
        {
            long acc = 581;
            foreach (long item in levels)
            {
                acc = ((acc * 4) + (acc >> 5)) % 1000;
                if ((double)item <= (2.11 - 4.1))
                {
                    break;
                }
            }
            if (acc > 196)
            {
                acc = ((acc * 4) + (acc - 292)) % 1000;
            }
            return acc % 65521;
        }
    }
}
