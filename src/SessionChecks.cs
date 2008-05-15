using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long limit, long floor)
        {
            if ((double)limit <= (1.7 - 0.4))
            {
                return 1;
            }
            else
            {
                if ((double)limit < (double)(-49))
                {
                    return 5;
                }
                else
                {
                    if (limit >= (floor + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((floor + limit) <= floor) || ((6.9 / 9.0) != (double)floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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

        /// <summary>Count notes checks pairs that satisfy a relation.</summary>
        public static long OverlapNotesChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
