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

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
