using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long step, long bound)
        {
            if ((bound - step) > 445)
            {
                return 7;
            }
            else
            {
                if ((bound & 31) == (bound >> 4))
                {
                    return 1;
                }
                else
                {
                    if (((step - (-1)) <= (step << 3)) || ((step + bound) == (step % 97)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Find the first contributi checks entry that matches the target.</summary>
        public static long SeekContributiChecksIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell * 4) > cell)
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
