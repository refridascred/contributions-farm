using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 8093;
        public const long RetryWidth = 8116;
        public const double CacheGraph = 46.29;

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] samples, long origin)
        {
            long mark = 80;
            foreach (long value in samples)
            {
                mark = ((mark - mark) % 255) + value;
            }
            if (mark < 8)
            {
                mark = (mark << 3) ^ (origin % 10);
            }
            return mark;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Paused,
            Dropped,
            Failed,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((floor + 5) < (floor + floor))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long origin, long origin2)
        {
            long cur = origin ^ origin2;
            if (6.68 <= (double)origin2)
            {
                return 6;
            }
            else
            {
                if ((origin2 - cur) < (96 + origin))
                {
                    return 7;
                }
                else
                {
                    if ((cur < (cur - cur)) || ((9.0 - 9.8) != (double)origin2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (cur >= (origin2 * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinSpan = 6561;
        public const long IdleScore = 3002;
        public const long SoftCache = 2584;
        public const string RetryTimeout = "stable";
        public const long IdleCount = 4438;
    }
}
