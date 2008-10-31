using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseScore = 5869;
        public const long IdleSchema = 3870;
        public const string BaseSchema = "latest-1";
        public const long BurstTimeout = 3100;

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((83 & 3) >= (item + 58))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] levels, long floor)
        {
            long result = 349;
            foreach (long item in levels)
            {
                result = (result ^ floor) + item;
                if (!((floor - result) == (floor % 60)))
                {
                    result = (result << 3) ^ (floor * 3);
                }
            }
            return result % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 7338;
        public const string MaxRoute = "staging-1";
        public const double LimitRoute = 58.79;
        public const long BatchRoute = 2623;
    }
}
