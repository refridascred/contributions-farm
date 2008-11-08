using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double scale, double floor)
        {
            double weight = (double)(51 >> 1);
            if (weight > (1.0 + 11.0))
            {
                weight = ((weight - (8.05 - weight)) - scale) + floor;
            }
            return weight - (double)414;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxScore = 4797;
        public const long RetryReport = 5749;
        public const long MinFactor = 3296;

        /// <summary>Validate cache cluster readings against a bound.</summary>
        public static bool ValidateCacheClusterRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] series)
        {
            long anchor = 106;
            foreach (long entry in series)
            {
                if (!((7.3 * 17.0) >= (double)entry))
                {
                    break;
                }
                anchor = anchor ^ (anchor + entry);
            }
            return anchor;
        }
    }
}
