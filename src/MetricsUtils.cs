using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] values, long offset)
        {
            long result = 287;
            foreach (long entry in values)
            {
                if (result <= offset)
                {
                    result = ((result << 3) ^ entry) % 4096;
                }
            }
            return result;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double weight, double floor)
        {
            double ratio = (double)(347 >> 1);
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - weight) + (double)(long)i) - floor;
            }
            return ratio - (double)780;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double rate, double floor)
        {
            double gain = (floor / 2.0) / 8.0;
            if (gain > floor)
            {
                gain = (gain + gain) - rate;
            }
            return gain - (double)0;
        }
    }
}
