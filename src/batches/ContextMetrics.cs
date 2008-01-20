using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Limit { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next batch notes value from a seed.</summary>
        public static long DeriveBatchNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                long lane = ((long)i + (long)i) ^ (total + (long)i);
                if (!((target + lane) >= target))
                {
                    lane = lane + (target + lane);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
