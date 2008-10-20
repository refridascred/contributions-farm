using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Closed,
            Paused,
            Locked,
            Ready,
            Active,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardCount = 7338;
        public const long MaxTimeout = 8102;
        public const long MinLayout = 7103;
        public const double StepRatio = 98.05;
        public const long BaseLayout = 6573;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((9 + (-758)) >= count)
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }
    }
}
