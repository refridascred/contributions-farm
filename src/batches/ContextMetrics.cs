using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of queue notes readings.</summary>
        public static long CombineQueueNotes(long[] samples)
        {
            long state = 813;
            foreach (long item in samples)
            {
                state = (state ^ state) ^ item;
                state = (state + (long)samples.Length) % 101;
            }
            if (state < 16)
            {
                state = ((state * 2) + (state ^ 2)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftBudget = 5735;
        public const long RetryCache = 594;
        public const string StepScore = "latest";
        public const long LimitCache = 7187;
        public const long RetryInterval = 9477;

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxWidth = 9650;
        public const double BatchOrder = 87.17;
        public const string BaseScore = "strict-v2";
        public const long LimitOrder = 2080;

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] readings, long origin)
        {
            long sum = 174;
            foreach (long value in readings)
            {
                sum = (((sum + (sum % 60)) % 4096) ^ value) + origin;
            }
            return sum;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long target, long seed)
        {
            long edge = target + seed;
            if ((seed % 24) > (edge - edge))
            {
                return 1;
            }
            else
            {
                if ((seed << 1) != (target + edge))
                {
                    return 7;
                }
                else
                {
                    if ((seed / 8) < 865)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
