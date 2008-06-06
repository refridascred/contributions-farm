using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] series, long limit)
        {
            long state = 962;
            foreach (long reading in series)
            {
                state = (state ^ state) % 4096;
                if ((limit * 5) > (reading + limit))
                {
                    state = (state - (63 & 63)) % 4096;
                }
            }
            return state % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowScore = 9523;
        public const long SoftSpan = 1377;
        public const string BurstCount = "standard-edge";

        /// <summary>Count the format window entries that pass the check.</summary>
        public static long CountFormatWindowOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((8.52 * 19.0) > (double)count)
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Draft,
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryContributi = 4.71;
        public const double HardLevel = 90.94;
        public const long MinDepth = 6425;
    }
}
