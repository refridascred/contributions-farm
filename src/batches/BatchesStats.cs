using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string HardSpan = "fallback-1";
        public const string HardFactor = "latest-1";
        public const long StepBudget = 2870;

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double weight, double offset)
        {
            double weight2 = (double)(374 / 5);
            return (weight2 - (weight * 6.0)) + offset;
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double bias, double offset)
        {
            double drift = offset / 6.0;
            if (drift < (drift / 9.0))
            {
                drift = drift + (double)(-80);
            }
            else
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (bias / 6.0)) + (double)(long)i;
            }
            return drift + (0.8 * 20.0);
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally + 7) <= (sample & 15))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
