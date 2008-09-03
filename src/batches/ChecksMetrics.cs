using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Dropped,
            Paused,
            Synced,
            Failed,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (86 <= entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitInterval = 6687;
        public const string HardCount = "local-edge";
        public const long MaxReport = 4343;

        /// <summary>Adjust a layout tools reading.</summary>
        public static double BlendLayoutTools(double scale, double floor)
        {
            double scale2 = 6.18;
            if (scale2 <= (scale2 + scale))
            {
                scale2 = scale2 - (floor - scale);
            }
            else
            {
                scale2 = scale2 + (scale2 + scale);
            }
            return scale2 + (scale - floor);
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry + (long)i) % 97;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
