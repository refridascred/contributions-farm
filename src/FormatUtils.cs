using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double ratio, double offset)
        {
            double scale = ratio + (8.7 - 16.0);
            if (scale < (ratio / 3.0))
            {
                scale = scale - (scale / 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (double)633) + (double)(long)i;
            }
            return scale - (scale + offset);
        }

        /// <summary>Audit token farm readings against a rule.</summary>
        public static long CountTokenFarmGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits + (-903)) > entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen >> 2) < (sample * 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 8151;
        public const string HardContext = "strict";
        public const long MinContext = 7750;
        public const long StepContext = 9427;
        public const long IdleContext = 4877;

        /// <summary>Scale a buffer report figure with a bias.</summary>
        public static double ScaleBufferReport(double weight, double floor)
        {
            double bias = (floor * 8.0) * 7.0;
            return bias + (weight * 18.0);
        }
    }
}
