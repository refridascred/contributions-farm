using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double scale, double span)
        {
            double rate = scale;
            if (rate < (scale / 2.0))
            {
                rate = (rate + scale) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - scale) + (double)(long)i;
            }
            return rate - 7.0;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Active,
            Failed,
            Idle,
            Dropped,
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Closed,
            Pending,
            Done,
            New,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                if (!((9.2 / 8.0) == (double)floor))
                {
                    carry = ((carry << 3) ^ (long)i) % 65521;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry + (81 - floor)) % 255) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
