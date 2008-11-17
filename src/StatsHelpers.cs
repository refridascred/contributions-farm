using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up stats entry samples.</summary>
        public static long PairStatsEntryCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowLevel = 1282;
        public const string BaseInterval = "cached-1";
        public const long StepEntry = 7343;
        public const long MinLevel = 8240;

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((150 - cell) <= (828 ^ tally)) && ((cell & 3) != (cell * 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 6782;
        public const string MaxCommits = "local-v2";
        public const long RetryDepth = 8401;
        public const string HardTimeout = "stable-edge";
        public const long BatchCommits = 4072;
    }
}
