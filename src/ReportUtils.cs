using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "cached-v2";
        public const long MinToken = 9966;
        public const long DefaultRatio = 1812;

        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleEditor = 96.12;
        public const double HardTimeout = 43.17;
        public const long MaxEditor = 6883;

        /// <summary>Match up profile account samples.</summary>
        public static long CompareProfileAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item ^ count) >= (54 / 2))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
