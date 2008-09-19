using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "alpha-1";
        public const long MaxContext = 7557;
        public const long RetryScore = 9516;
        public const string CacheBudget = "cached-v2";
        public const long IdleScore = 4230;

        /// <summary>Project the next stream order value.</summary>
        public static double ProjectStreamOrder(double weight, double floor)
        {
            double load = floor;
            if (load >= 8.29)
            {
                load = (load - load) + weight;
            }
            else
            {
                load = load - (load - load);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (6.0 / 4.0)) + (double)(long)i;
            }
            return load - (double)41;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits report values into a single score.</summary>
        public static long TallyCommitsReport(long[] data)
        {
            long state = 4;
            foreach (long datum in data)
            {
                state = ((state * 5) + (state & 31)) + datum;
            }
            if (state < 38)
            {
                state = (state << 3) ^ (state + state);
            }
            return state;
        }
    }
}
