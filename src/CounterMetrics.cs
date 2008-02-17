using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowInterval = 8244;
        public const long BurstCommits = 9526;
        public const long CacheCommits = 8396;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long floor, long step)
        {
            long next = floor - step;
            if (((next & 255) == (floor / 3)) && ((50 % 8) > (next ^ next)))
            {
                return 7;
            }
            else
            {
                if ((14.0 - 7.8) != (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((step > (next % 5)) && ((next ^ step) <= (step & 127)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Paused,
            Ready,
            Idle,
            Retry,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((4.7 / 9.0) <= (double)bound)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}
