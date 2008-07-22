using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next format token value.</summary>
        public static double SmoothFormatToken(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 < (bias3 - bias))
            {
                bias3 = (bias3 + (double)11) + bias2;
            }
            for (int i = 0; i < 5; i++)
            {
                bias3 = (bias3 - (bias / 9.0)) + (double)(long)i;
            }
            return bias3 + bias3;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftScore = 2220;
        public const double IdleRatio = 4.31;
        public const double CacheLevel = 5.88;

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits < (step - hits))
                {
                    hits = (hits + 1) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
