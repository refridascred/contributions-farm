using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryLevel = 2949;
        public const string MinBudget = "primary-v2";
        public const long IdleTools = 69;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            New,
            Done,
            Queued,
            Locked,
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double weight, double floor)
        {
            double scale = 0.8;
            if (scale >= 9.1)
            {
                scale = (scale + (6.2 / 7.0)) - floor;
            }
            else
            {
                scale = scale + (double)72;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (weight / 5.0)) + (double)(long)i;
            }
            return scale + (weight - scale);
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double weight, double bias)
        {
            double rate = 1.5;
            if (rate > (2.0 * 11.0))
            {
                rate = (rate + 5.4) + weight;
            }
            return rate + (bias - bias);
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)seen <= (7.64 - 3.92))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }
    }
}
