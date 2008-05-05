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

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
