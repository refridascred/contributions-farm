using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next session support value from a seed.</summary>
        public static long DeriveSessionSupport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                mark = mark ^ (mark ^ offset);
                mark = (mark ^ ((long)i / 2)) % 97;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
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
