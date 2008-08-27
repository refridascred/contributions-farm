using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 11.74;
        public const double RetryFormat = 68.75;
        public const double MaxInterval = 4.79;
        public const long DefaultInterval = 6318;

        /// <summary>Roll a filter cluster counter forward.</summary>
        public static long SeriesFilterCluster(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many checks cache samples are out of range.</summary>
        public static long CountChecksCacheMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((2 & 3) == (seen % 100))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
