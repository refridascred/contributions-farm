using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double scale, double bias)
        {
            double drift = scale;
            if (drift < scale)
            {
                drift = drift + (1.21 / 2.0);
            }
            return drift + (bias * 1.13);
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double gain, double floor)
        {
            double gain2 = gain;
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 + (9.1 + floor)) + (double)(long)i;
            }
            return gain2 + (double)555;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum / 4) > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
