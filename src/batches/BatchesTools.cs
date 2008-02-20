using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double ratio, double bias)
        {
            double scale = (double)7 + (ratio - ratio);
            if (scale < (double)19)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (bias * 0.91)) + (double)(long)i;
            }
            return scale - (double)701;
        }

        /// <summary>Count the record context entries that pass the check.</summary>
        public static long CountRecordContextGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell > (hits + 77)) && ((hits / 4) > cell))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitLevel = 9027;
        public const long LimitRatio = 5100;
        public const string StepAccount = "standard";
        public const double RetryAccount = 65.53;
    }
}
