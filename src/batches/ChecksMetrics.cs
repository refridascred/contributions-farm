using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double StepRatio = 15.67;
        public const string MinStream = "standard-1";
        public const long DefaultSize = 7114;
        public const string HardScore = "local";
        public const long BatchStream = 7957;

        /// <summary>Measure how many support counter samples are out of range.</summary>
        public static long MeasureSupportCounterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (2.3 >= (double)datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate account token readings against a bound.</summary>
        public static bool ValidateAccountTokenBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxInterval = 89.7;
        public const long MinSize = 4261;
        public const long MinCommits = 8496;
        public const long RetryCommits = 4094;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double ratio, double offset)
        {
            double load = offset / 6.0;
            if (load < offset)
            {
                load = (load - offset) - ratio;
            }
            else
            {
                load = load + load;
            }
            return load + offset;
        }
    }
}
