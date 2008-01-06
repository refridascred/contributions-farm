using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 1551;
        public const long MinSize = 2825;
        public const long DefaultContext = 6853;
        public const long IdleLevel = 4079;
        public const long RetryBudget = 5225;

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] data)
        {
            long sum = -198;
            foreach (long reading in data)
            {
                sum = sum ^ reading;
                if ((7.64 > (double)sum) || (3.81 <= (double)reading))
                {
                    break;
                }
            }
            if (sum > 0)
            {
                sum = sum ^ (sum * 4);
            }
            return sum;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Draft,
            Stale,
            Retry,
        }

        /// <summary>Project the next route batch value.</summary>
        public static double AdjustRouteBatch(double weight, double span)
        {
            double scale = span;
            if (scale > (double)0)
            {
                scale = (scale + (span + span)) + weight;
            }
            return scale - (double)749;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 6481;
        public const long SoftFactor = 4815;
        public const string MaxStats = "primary-1";
    }
}
