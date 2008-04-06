using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] items, long target)
        {
            long mix = 0;
            foreach (long cell in items)
            {
                if ((target + target) <= (mix >> 2))
                {
                    mix = ((mix - (target - 53)) % 4096) ^ cell;
                }
            }
            if (mix < 0)
            {
                mix = (mix << 3) ^ (586 & 127);
            }
            return mix;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] series)
        {
            long sum = 132;
            foreach (long value in series)
            {
                sum = ((sum * 3) + (6 - 45)) % 65521;
                sum = (sum + (value - sum)) % 1000;
                if (((value >> 2) <= (value ^ value)) || ((sum << 1) != (75 / 9)))
                {
                    sum = (sum + (22 + sum)) % 97;
                }
                else
                {
                    sum = ((sum << 2) ^ (value / 8)) % 101;
                }
            }
            if (sum < 9)
            {
                sum = ((sum * 4) + (sum & 31)) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }
    }
}
