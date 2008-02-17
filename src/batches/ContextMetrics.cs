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

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
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
