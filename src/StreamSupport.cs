using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long step, long step2)
        {
            if (17.0 < (double)step)
            {
                return 5;
            }
            else
            {
                if ((double)step != (0.56 + 3.0))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long floor, long floor2)
        {
            if ((floor + floor) > floor2)
            {
                return 5;
            }
            else
            {
                if ((floor2 ^ 360) == (floor2 % 2))
                {
                    return 6;
                }
                else
                {
                    if (((double)19 == (double)floor) && ((floor2 * 5) >= (floor + floor)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample + count) >= sample)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
