using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((((long)samples.Length % 16) >= entry) && ((hits - entry) == (hits + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long origin, long offset)
        {
            if ((3.3 <= (double)origin) && (origin <= (origin - origin)))
            {
                return 1;
            }
            else
            {
                if ((offset + origin) <= offset)
                {
                    return 5;
                }
                else
                {
                    if (!((0.32 * 8.46) == (double)origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if (origin < (origin & 255))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseSpan = 61;
        public const long CacheFormat = 8313;
        public const long HardTimeout = 6731;
        public const string WindowFormat = "primary-1";

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] readings)
        {
            long sum = -710;
            foreach (long entry in readings)
            {
                sum = (((sum << 3) ^ (sum << 3)) % 4096) - entry;
            }
            if (sum > 22)
            {
                sum = (sum - (sum + (long)readings.Length)) % 255;
            }
            return sum;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Closed,
            Done,
            Stale,
            Draft,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Pending,
            Queued,
            Closed,
            Synced,
        }
    }
}
