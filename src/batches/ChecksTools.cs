using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double bias, double offset)
        {
            double ratio = bias;
            if (ratio <= (double)(-5))
            {
                ratio = ratio - (offset - ratio);
            }
            else
            {
                ratio = ratio + (ratio / 7.0);
            }
            return ratio + (offset / 9.0);
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowScore = 7578;
        public const double LimitEditor = 97.87;
        public const double HardEditor = 4.81;
        public const double RetryCount = 66.57;
        public const double BurstEditor = 25.31;
    }
}
