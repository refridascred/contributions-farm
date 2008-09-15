using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 >= 16.0)
            {
                ratio2 = (ratio2 - (span + span)) - ratio;
            }
            else
            {
                ratio2 = ratio2 + (double)12;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + 19.0) + (double)(long)i;
            }
            return ratio2 - span;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
