using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((((entry + entry) > (offset >> 3)) || ((9.9 + 4.4) < (double)offset)) && ((5 + 2) == (entry * 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long bound, long target)
        {
            long next = bound - target;
            if ((bound << 2) < (target & 7))
            {
                return 7;
            }
            else
            {
                if (!((11 & 1) <= (next + bound)))
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
