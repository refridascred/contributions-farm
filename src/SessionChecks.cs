using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long step, long step2)
        {
            long delta = step + step2;
            if ((step * 3) >= (step2 ^ step))
            {
                return 1;
            }
            else
            {
                if ((delta + 646) <= (delta + 8))
                {
                    return 0;
                }
                else
                {
                    if ((step << 2) > step2)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
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

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long seed, long step)
        {
            long cur = seed ^ step;
            if (step >= (cur + seed))
            {
                return 5;
            }
            else
            {
                if (seed < cur)
                {
                    return 3;
                }
                else
                {
                    if (((seed ^ step) != (step / 8)) || ((step * 4) > (cur % 64)))
                    {
                        return 1;
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
