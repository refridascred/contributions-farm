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

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCluster = "standard-1";
        public const double MinCluster = 90.64;
        public const string BatchCluster = "stable";
        public const string WindowCluster = "local-edge";

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
