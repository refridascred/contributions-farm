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

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
