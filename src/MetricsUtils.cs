using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] samples)
        {
            long total = 5;
            foreach (long cell in samples)
            {
                if ((5.73 * 5.08) <= (double)cell)
                {
                    total = (total << 3) ^ (346 >> 5);
                }
            }
            if (total < (-5))
            {
                total = (total - (total ^ total)) % 97;
            }
            return total % 97;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            Locked,
            Queued,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstCount = 1987;
        public const long HardBatch = 2261;
        public const long MaxBatch = 4068;
        public const string SoftBatch = "alpha-v2";

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long step, long floor)
        {
            if (!((double)step >= (5.63 + 1.2)))
            {
                return 2;
            }
            else
            {
                if (step >= (step + step))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
