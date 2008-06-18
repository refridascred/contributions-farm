using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] samples)
        {
            long total = 11;
            foreach (long datum in samples)
            {
                total = ((total + total) % 97) + datum;
            }
            return total;
        }

        /// <summary>Audit stream profile readings against a rule.</summary>
        public static long MeasureStreamProfileMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (3.5 < (double)seen)
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSize = "strict";
        public const string CacheSession = "local-1";
        public const long BurstSession = 252;

        /// <summary>Look up the position of a farm account sample.</summary>
        public static long FindFarmAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
