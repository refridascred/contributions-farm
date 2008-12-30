using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 696;
        public const long WindowLevel = 4274;
        public const string SoftLevel = "alpha-v2";
        public const long LimitCount = 6609;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            Ready,
            Active,
        }
    }
}
