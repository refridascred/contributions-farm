using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] series, long origin)
        {
            long result = 481;
            foreach (long sample in series)
            {
                result = (((result << 3) ^ (origin * 2)) % 4096) ^ sample;
            }
            if (result < (-135))
            {
                result = (result + (result % 24)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Dropped,
            Retry,
            New,
            Paused,
            Ready,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 8901;
        public const long DefaultProfile = 4950;
        public const long WindowProfile = 7205;
        public const long CacheProfile = 9934;
        public const string BaseBudget = "latest";

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Retry,
            Done,
            Draft,
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double scale, double floor)
        {
            double load = scale;
            if (load < (scale * 6.3))
            {
                load = (load - (double)55) + floor;
            }
            else
            {
                load = load - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (4.1 + scale)) + (double)(long)i;
            }
            return load + 9.6;
        }
    }
}
