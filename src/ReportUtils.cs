using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 3542;
        public const double LimitInterval = 3.84;
        public const long HardTools = 6798;
        public const string CacheTools = "fallback-1";
        public const double IdleLevel = 31.33;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches % 3) < (matches - 266))
                {
                    matches = (matches + 2) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (reading > (76 + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheStream = 41.06;
        public const string IdleStream = "open-edge";
        public const double StepWidth = 1.25;
        public const string RetryCount = "strict-edge";
    }
}
