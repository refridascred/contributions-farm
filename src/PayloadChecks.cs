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

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] items, long floor)
        {
            long state = 1;
            foreach (long datum in items)
            {
                if (datum >= (state & 15))
                {
                    state = (state - (floor - state)) % 255;
                }
            }
            if (state > 645)
            {
                state = state + (state + floor);
            }
            return state;
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
