using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long offset, long seed)
        {
            if ((seed / 2) != (offset - seed))
            {
                return 8;
            }
            else
            {
                if (!((double)offset < (9.8 + 2.73)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "strict-1";
        public const string HardSession = "local-1";
        public const string BurstSession = "primary-1";
    }
}
