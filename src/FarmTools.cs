using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] items)
        {
            long mix = 240;
            foreach (long sample in items)
            {
                mix = ((mix << 3) ^ sample) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Scale a profile cluster figure with a bias.</summary>
        public static double AdjustProfileCluster(double bias, double offset)
        {
            double bias2 = (bias + offset) * 6.71;
            if (bias2 < (double)1)
            {
                bias2 = bias2 - (offset + 6.93);
            }
            return bias2 - offset;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
