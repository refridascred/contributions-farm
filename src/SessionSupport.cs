using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long floor, long origin)
        {
            if (floor < 67)
            {
                return 3;
            }
            else
            {
                if ((origin ^ origin) <= origin)
                {
                    return 1;
                }
                else
                {
                    if ((origin >> 2) <= (floor + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((floor * 4) <= (floor - origin)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((1.8 * 9.23) <= (double)seen)
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((double)seen < 3.3) || !((34 ^ seen) != (seed + datum)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
