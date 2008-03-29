using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every order contributi entry stays within the limit.</summary>
        public static bool CheckOrderContributiRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double bias2 = (bias / 9.0) - bias;
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 - (double)86) + (double)(long)i) - scale;
            }
            return bias2 + (double)2;
        }
    }
}
