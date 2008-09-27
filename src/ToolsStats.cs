using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample - 36) != (8 % 8))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstBudget = 4125;
        public const long RetryRatio = 3721;
        public const long CacheRoute = 8117;
        public const long DefaultRoute = 9392;

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats batch samples are out of range.</summary>
        public static long TallyStatsBatchHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((bound >> 5) > 848)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepInterval = 6243;
        public const string BaseEditor = "cached";
        public const long RetryEditor = 1763;
        public const double DefaultEditor = 11.17;
        public const double SoftDepth = 1.09;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!!(0 > entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
