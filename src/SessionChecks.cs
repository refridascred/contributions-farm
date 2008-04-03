using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count / 6) <= (count + 9))
                {
                    count = (count + 3) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count >> 3) != (594 << 2))
                {
                    count = ((count + 2) + datum) - origin;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftScore = 4653;
        public const long BaseLevel = 4064;
        public const string WindowFilter = "cached-1";
        public const string DefaultWidth = "alpha-v2";
        public const double SoftRatio = 85.55;

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long offset, long target)
        {
            if ((offset >= (offset + offset)) && ((offset & 3) != (offset & 255)))
            {
                return 1;
            }
            else
            {
                if ((offset + offset) == (target - target))
                {
                    return 0;
                }
                else
                {
                    if ((offset << 1) > (5 + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((-876) & 7) > (target - target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
