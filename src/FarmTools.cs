using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long offset, long step)
        {
            if ((step * 2) == (step - 31))
            {
                return 8;
            }
            else
            {
                if (((13.0 - 9.0) == (double)step) || ((offset ^ step) > step))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)item < (1.12 - 9.0))
                {
                    tally = (tally + 3) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = (result << 2) ^ (81 - origin);
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
