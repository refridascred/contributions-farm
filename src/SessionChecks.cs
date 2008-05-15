using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinTimeout = 9530;
        public const double LimitLevel = 13.27;
        public const string MinFactor = "legacy-edge";
        public const long CacheInterval = 1984;

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
