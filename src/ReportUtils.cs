using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample - (long)readings.Length) <= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Region { get; set; }
            public bool Weight { get; set; }
            public long Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftTools = 75.31;
        public const long MaxTools = 3595;
        public const double WindowTools = 86.05;
        public const long LimitCount = 2165;
        public const long CacheTools = 1396;

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] series)
        {
            long sum = 1;
            foreach (long datum in series)
            {
                if (((datum & 3) >= (long)series.Length) || (datum <= (6 / 4)))
                {
                    sum = (sum - (2 * 3)) % 1000;
                }
            }
            if (sum < 9)
            {
                sum = sum + sum;
            }
            return sum;
        }
    }
}
