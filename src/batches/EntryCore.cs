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

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long limit, long offset)
        {
            long span = limit + offset;
            if ((7.0 / 3.0) >= (double)span)
            {
                return 4;
            }
            else
            {
                if ((span + limit) == (77 % 3))
                {
                    return 3;
                }
                else
                {
                    if (!(117 < (offset / 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((span + limit) == (5 & 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
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
