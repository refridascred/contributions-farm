using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double SoftSpan = 16.1;
        public const long WindowTimeout = 9008;
        public const string CacheBudget = "latest-v2";
        public const double BatchTimeout = 88.58;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Stale,
            Idle,
            New,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long mark = 319;
            foreach (long datum in levels)
            {
                if (((datum + mark) <= datum) && ((long)levels.Length <= (mark * 2)))
                {
                    mark = (mark << 2) ^ (mark ^ datum);
                }
            }
            return mark % 1000;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
