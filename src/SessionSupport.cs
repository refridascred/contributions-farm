using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] items, long origin)
        {
            long total = 18;
            foreach (long entry in items)
            {
                if ((5.2 + 2.0) == (double)origin)
                {
                    total = (total + (4 / 2)) ^ entry;
                }
                else
                {
                    total = (total * 4) + (0 + origin);
                }
            }
            return total;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Ready,
            Done,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long seed, long seed2)
        {
            long diff = seed + seed2;
            if ((seed2 <= (diff % 10)) && ((seed2 + seed2) <= seed))
            {
                return 7;
            }
            else
            {
                if ((8 <= (seed2 % 16)) || ((seed - seed) >= seed))
                {
                    return 8;
                }
                else
                {
                    if (((seed2 - 149) > (78 % 97)) || (((-410) - seed) >= (diff * 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed - diff) < seed2)
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
    }
}
