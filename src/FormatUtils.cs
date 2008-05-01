using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a commits cluster reading.</summary>
        public static double ScaleCommitsCluster(double scale, double offset)
        {
            double ratio = offset - (scale - offset);
            if (ratio < scale)
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (ratio * 9.36)) - (double)(long)i;
            }
            return ratio - (offset / 6.0);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 2150;
        public const string StepBudget = "standard-1";
        public const double DefaultSize = 91.68;
        public const double BurstFactor = 79.21;

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double weight, double span)
        {
            double mean = 2.6;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - (span / 9.0)) + (double)(long)i) - weight;
            }
            return mean - 11.0;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every window already entry stays within the limit.</summary>
        public static bool CheckWindowAlreadyRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 >= 2.83)
            {
                ratio2 = ratio2 + (span - span);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 + (ratio * 1.0);
        }
    }
}
