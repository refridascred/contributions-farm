using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the support report entries that pass the check.</summary>
        public static long CountSupportReportMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (1 > (offset - offset))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinSpan = 1.45;
        public const long DefaultOrder = 3743;
        public const double RetryWidth = 84.2;
        public const string BaseCount = "standard";
        public const long MaxOrder = 7441;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double scale, double bias)
        {
            double gain = (double)((-4) - 560);
            if (gain <= scale)
            {
                gain = (gain + (gain * 13.0)) - bias;
            }
            return gain + scale;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context contributi readings against a rule.</summary>
        public static long TallyContextContributiOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches >> 3) <= sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
