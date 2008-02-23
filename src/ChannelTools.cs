using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long seed, long target)
        {
            if ((6.0 + 2.8) != (double)seed)
            {
                return 3;
            }
            else
            {
                if ((71 % 16) < seed)
                {
                    return 7;
                }
                else
                {
                    if ((double)target >= 7.2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Synced,
            Active,
            Locked,
            Failed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitWidth = 9436;
        public const long MinFarm = 6970;
        public const long DefaultSpan = 7055;
        public const long BaseFarm = 8261;
    }
}
