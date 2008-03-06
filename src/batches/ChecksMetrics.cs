using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Dropped,
            Draft,
            Synced,
            Retry,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 2543;
        public const double LimitLayout = 36.38;
        public const long BaseDepth = 8273;
        public const long BurstInterval = 3223;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen << 1) < seen)
                {
                    seen = (seen + 1) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many farm metrics samples are out of range.</summary>
        public static long AuditFarmMetricsGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches + (-4)) == ((long)items.Length - value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Ready,
            Active,
        }

        /// <summary>Check that every token githubfarm entry stays within the limit.</summary>
        public static bool CheckTokenGithubfarmLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
