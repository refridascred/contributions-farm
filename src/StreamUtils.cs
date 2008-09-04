using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first entry layout entry that matches the target.</summary>
        public static long LocateEntryLayoutIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 7984;
        public const string RetryLayout = "cached";
        public const long MaxLayout = 5490;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double ratio, double floor)
        {
            double drift = (double)(53 >> 1);
            if (drift > ratio)
            {
                drift = drift + ratio;
            }
            else
            {
                drift = drift + (drift - 1.37);
            }
            return drift - floor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxTools = 76.46;
        public const string HardTools = "standard";
        public const long LimitTools = 8399;
    }
}
