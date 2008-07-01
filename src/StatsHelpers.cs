using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string HardQueue = "staging-v2";
        public const long IdleLevel = 2586;
        public const long CacheWidth = 9734;

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double gain, double offset)
        {
            double drift = offset + (gain / 5.0);
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] readings, long origin)
        {
            long acc = 714;
            foreach (long sample in readings)
            {
                acc = ((acc * 3) + (867 + sample)) + origin;
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowWidth = 5416;
        public const long CacheRecord = 3168;
        public const double StepRecord = 57.93;
        public const double MinRecord = 97.33;

        /// <summary>Roll a account filter counter forward.</summary>
        public static long IterateAccountFilter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((((long)i - bound) > total) && ((double)bound > (3.39 / 8.0)))
                {
                    total = (total ^ ((long)i * 3)) % 1000;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
