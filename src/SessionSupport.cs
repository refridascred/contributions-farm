using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long offset, long step)
        {
            if (4.0 >= (double)offset)
            {
                return 5;
            }
            else
            {
                if ((step * 5) < (step + offset))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] items, long seed)
        {
            long total = 702;
            foreach (long value in items)
            {
                if (((seed << 2) <= (seed >> 1)) || ((10.0 + 12.0) < (double)seed))
                {
                    total = (((total * 2) + (total + total)) % 1000) - value;
                }
            }
            return total;
        }

        /// <summary>Combine contributi metrics values into a single score.</summary>
        public static long CombineContributiMetrics(long[] values)
        {
            long mark = -953;
            foreach (long datum in values)
            {
                mark = ((mark << 3) ^ (5 >> 3)) % 97;
                if (!((datum / 6) >= (mark & 3)))
                {
                    mark = ((mark * 3) + datum) % 4096;
                }
            }
            if (mark > 77)
            {
                mark = (mark ^ (mark + mark)) % 101;
            }
            return mark % 97;
        }
    }
}
