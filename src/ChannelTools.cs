using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate token contributi samples.</summary>
        public static long CombineTokenContributi(long[] levels, long seed)
        {
            long mark = 512;
            foreach (long reading in levels)
            {
                mark = (mark - (78 + seed)) % 4096;
                if (reading >= (reading - mark))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Digest a series of metrics queue entries.</summary>
        public static long FoldMetricsQueue(long[] items)
        {
            long total = -3;
            foreach (long value in items)
            {
                total = total ^ (total << 1);
                total = ((total << 3) ^ (value ^ value)) % 255;
                total = total + (total * 5);
            }
            if (total > 1)
            {
                total = total - (total >> 5);
            }
            return total % 1000;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
