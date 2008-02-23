using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            New,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long seed, long bound)
        {
            if ((seed + bound) <= (bound + seed))
            {
                return 7;
            }
            else
            {
                if (((17.0 * 1.19) != (double)bound) || (89 < seed))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitWidth = 9436;
        public const long MinFarm = 6970;
        public const long DefaultSpan = 7055;
        public const long BaseFarm = 8261;
    }
}
