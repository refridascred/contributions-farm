using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFarm = 37.92;
        public const double DefaultFarm = 76.78;
        public const long SoftSize = 7275;
        public const long RetryFarm = 6234;
        public const long BurstBudget = 3627;

        /// <summary>Project the next notes metric value.</summary>
        public static double BlendNotesMetric(double gain, double floor)
        {
            double bias = (double)(7 + (-640));
            if (bias <= bias)
            {
                bias = ((bias + (double)163) - gain) + floor;
            }
            else
            {
                bias = bias - bias;
            }
            return bias + 6.0;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] levels, long seed)
        {
            long total = 1;
            foreach (long datum in levels)
            {
                if ((77 - total) <= (datum >> 4))
                {
                    total = ((total * 3) + (datum + (long)levels.Length)) + seed;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Stale,
            Locked,
            Done,
        }
    }
}
