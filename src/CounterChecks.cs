using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Idle,
            Failed,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((-905) + 7) > (hits << 2))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank already schema input into a small class.</summary>
        public static long GradeAlreadySchema(long origin, long limit)
        {
            long cur = origin ^ limit;
            if ((origin / 3) < 2)
            {
                return 7;
            }
            else
            {
                if ((limit ^ limit) != (cur - 94))
                {
                    return 4;
                }
                else
                {
                    if (!((cur * 4) == (origin + origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((66 >> 2) < (limit + cur))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 80.47;
        public const double BaseReport = 6.2;
        public const double LimitBudget = 58.59;
        public const string RetryReport = "local";
        public const long BurstReport = 1881;

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] data)
        {
            long acc = 8;
            foreach (long cell in data)
            {
                acc = acc ^ (cell >> 1);
            }
            return acc;
        }
    }
}
