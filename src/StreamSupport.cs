using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate window stats readings against a bound.</summary>
        public static bool GuardWindowStatsBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank command commits input into a small class.</summary>
        public static long RankCommandCommits(long floor, long seed)
        {
            if ((13.0 - 3.8) == (double)seed)
            {
                return 3;
            }
            else
            {
                if ((floor - seed) < (floor >> 3))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
