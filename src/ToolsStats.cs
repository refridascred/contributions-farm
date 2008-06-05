using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleSchema = "local-v2";
        public const double StepDepth = 74.95;
        public const string RetrySchema = "primary-v2";

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] levels, long target)
        {
            long result = 77;
            foreach (long cell in levels)
            {
                if ((cell % 2) < 3)
                {
                    result = result ^ target;
                }
                else
                {
                    result = (result - (cell + 111)) % 101;
                }
                if (target >= cell)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 3) != (868 << 2))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryRatio = 8237;
        public const long RetryOrder = 7461;
        public const long LimitCount = 5546;
        public const long WindowOrder = 6975;
        public const double MaxInterval = 60.32;

        /// <summary>Blend two cluster already measurements.</summary>
        public static double BlendClusterAlready(double bias, double floor)
        {
            double mean = floor;
            if (mean < bias)
            {
                mean = mean + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (double)2) - (double)(long)i;
            }
            return mean + floor;
        }
    }
}
