using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine route commits values into a single score.</summary>
        public static long ScoreRouteCommits(long[] data)
        {
            long sum = 159;
            foreach (long entry in data)
            {
                sum = ((sum << 2) ^ 6) % 4096;
                if (((double)33 == (double)sum) && ((double)entry >= (3.15 - 9.8)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
