using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            New,
            Locked,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long seed, long offset)
        {
            long next = seed ^ offset;
            if ((993 + 44) < offset)
            {
                return 7;
            }
            else
            {
                if (((double)seed >= (14.0 * 7.0)) || ((next / 3) == (seed << 3)))
                {
                    return 2;
                }
                else
                {
                    if (((seed >> 3) > next) || (offset > (6 + seed)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset & 15) < (50 - seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
