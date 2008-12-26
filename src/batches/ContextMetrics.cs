using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long floor, long target)
        {
            long gap = floor ^ target;
            if ((22 - target) >= (gap << 2))
            {
                return 1;
            }
            else
            {
                if (((double)target <= (double)gap) || ((floor - target) >= gap))
                {
                    return 5;
                }
                else
                {
                    if ((target & 7) < floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitTimeout = 5166;
        public const long RetryEntry = 5483;
        public const double LimitEntry = 57.02;
        public const long SoftEntry = 5139;

        /// <summary>Locate a payload graph reading by value.</summary>
        public static long FindPayloadGraphIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            New,
            Ready,
            Closed,
            Locked,
            Queued,
        }
    }
}
