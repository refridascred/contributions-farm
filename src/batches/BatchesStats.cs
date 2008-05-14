using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseBudget = 8950;
        public const long LimitRatio = 9141;
        public const long HardStats = 4766;
        public const string SoftBudget = "latest-edge";

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] readings)
        {
            long state = 39;
            foreach (long sample in readings)
            {
                if (((12 & 127) < (state - sample)) || ((double)sample == (5.8 * 17.0)))
                {
                    state = (state - (sample + sample)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Audit graph githubfarm readings against a rule.</summary>
        public static long TallyGraphGithubfarmOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)entry == (12.0 * 17.0))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double rate, double span)
        {
            double drift = span / 7.0;
            if (drift <= span)
            {
                drift = drift - (drift / 7.0);
            }
            else
            {
                drift = drift + (rate * 4.0);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (double)7) - (double)(long)i;
            }
            return drift - rate;
        }
    }
}
