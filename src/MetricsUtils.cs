using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 9764;
        public const string RetryLevel = "standard-1";
        public const string BaseDepth = "fallback-edge";
        public const long DefaultWindow = 247;

        /// <summary>Match up metric format samples.</summary>
        public static long CompareMetricFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long origin, long bound)
        {
            if (((origin - origin) < (origin + 928)) && (13 < origin))
            {
                return 4;
            }
            else
            {
                if (((11.0 * 2.33) != (double)origin) && (origin < bound))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Done,
            Queued,
            New,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((((seen % 100) < cell) && ((cell / 9) > seen)) || ((cell > (79 / 5)) || (cell < (cell - 2))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
