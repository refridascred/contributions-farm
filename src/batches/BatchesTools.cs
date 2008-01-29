using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] readings, long offset)
        {
            long carry = 57;
            foreach (long reading in readings)
            {
                if (!((double)(long)readings.Length >= (9.0 * 9.8)))
                {
                    carry = ((((carry * 3) + (carry << 3)) % 101) + reading) - offset;
                }
            }
            return carry;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long step, long offset)
        {
            long lane = step + offset;
            if ((offset + lane) >= (step + 421))
            {
                return 8;
            }
            else
            {
                if (!(7 <= (lane - lane)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
