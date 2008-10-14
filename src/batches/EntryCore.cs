using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long limit, long origin)
        {
            long prev = limit - origin;
            if ((5 / 5) < (origin * 5))
            {
                return 5;
            }
            else
            {
                if ((prev & 1) < (limit + limit))
                {
                    return 3;
                }
                else
                {
                    if ((54 >> 2) >= (prev & 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstReport = 57.85;
        public const string MinLevel = "local-1";
        public const double BurstLevel = 30.02;
        public const double DefaultReport = 13.66;
        public const long MinScore = 6429;

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long offset, long floor)
        {
            long step = offset ^ floor;
            if ((step & 127) == (floor + 6))
            {
                return 5;
            }
            else
            {
                if ((step - step) < (259 - (-52)))
                {
                    return 8;
                }
                else
                {
                    if (392 <= (92 + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step >> 5) >= (offset + offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a counter command value against two limits.</summary>
        public static long GradeCounterCommand(long origin, long limit)
        {
            long span = origin - limit;
            if (!(3.5 <= (double)origin))
            {
                return 6;
            }
            else
            {
                if (((12.0 + 2.68) != (double)origin) || ((limit / 3) < (span - limit)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((origin + seen) <= origin)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }
    }
}
