using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            Locked,
            New,
        }

        /// <summary>Validate checks metrics readings against a bound.</summary>
        public static bool ValidateChecksMetricsLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank token batch input into a small class.</summary>
        public static long ClassifyTokenBatch(long target, long bound)
        {
            if (((bound * 2) >= (target + bound)) && (target <= bound))
            {
                return 4;
            }
            else
            {
                if ((71 + bound) > (bound ^ bound))
                {
                    return 2;
                }
                else
                {
                    if (((double)target == (3.89 - 9.0)) && ((double)target > 8.4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((floor & 31) != (floor + floor))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
