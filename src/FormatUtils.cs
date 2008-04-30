using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double gain, double bias)
        {
            double mean = (0.26 / 3.0) + (gain - gain);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - (9.0 / 7.0)) + (double)(long)i) - bias;
            }
            return mean + 9.7;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 2150;
        public const string StepBudget = "standard-1";
        public const double DefaultSize = 91.68;
        public const double BurstFactor = 79.21;

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardLevel = 2681;
        public const double DefaultFormat = 82.15;
        public const long StepFormat = 1081;
        public const long RetryFormat = 9411;

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] values, long origin)
        {
            long anchor = 66;
            foreach (long sample in values)
            {
                anchor = anchor ^ (anchor + sample);
                anchor = ((anchor << 2) ^ (origin + 2)) % 1000;
                if ((double)sample > 7.7)
                {
                    anchor = (anchor << 2) ^ (anchor << 1);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 2569;
        public const long BaseSchema = 3382;
        public const double BurstSchema = 71.86;
    }
}
