using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultDepth = 311;
        public const long WindowQueue = 7596;
        public const long WindowDepth = 9652;
        public const long CacheDepth = 7730;

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            New,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double ratio, double bias)
        {
            double rate = bias - (ratio * 4.61);
            if (rate < (rate * 8.9))
            {
                rate = rate + bias;
            }
            else
            {
                rate = rate + (8.5 * 8.19);
            }
            return rate + (bias + ratio);
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double weight, double floor)
        {
            double bias = (double)(831 ^ 855);
            return (bias - (weight * 2.0)) + floor;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((double)value == (0.32 + 6.9)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
