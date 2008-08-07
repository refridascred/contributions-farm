using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long offset, long floor)
        {
            if ((offset >> 2) >= 4)
            {
                return 8;
            }
            else
            {
                if ((double)offset < 1.4)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] series, long offset)
        {
            long total = 4;
            foreach (long datum in series)
            {
                if ((total & 7) > (offset - offset))
                {
                    total = (total * 3) + datum;
                }
                else
                {
                    total = total + total;
                }
            }
            if (total > 0)
            {
                total = (total + (652 - (long)series.Length)) % 65521;
            }
            return total;
        }
    }
}
