using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit layout githubfarm readings against a rule.</summary>
        public static long CountLayoutGithubfarmOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((4.4 * 4.67) == (double)entry)
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Blend two stream cluster measurements.</summary>
        public static double BlendStreamCluster(double bias, double offset)
        {
            double scale = offset;
            if (scale < (double)89)
            {
                scale = (scale - offset) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + 3.0;
        }

        /// <summary>Validate order command readings against a bound.</summary>
        public static bool CheckOrderCommandRange(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
