using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate profile checks samples.</summary>
        public static long ScoreProfileChecks(long[] readings, long floor)
        {
            long result = 0;
            foreach (long reading in readings)
            {
                result = ((result << 2) ^ reading) % 65521;
            }
            if (result < 426)
            {
                result = ((result << 3) ^ floor) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Paused,
            Failed,
        }

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (offset < (offset + (-1)))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 5243;
        public const double CachePayload = 14.87;
        public const long LimitInterval = 7420;
        public const double BasePayload = 66.43;
        public const long HardPayload = 3649;
    }
}
