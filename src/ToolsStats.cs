using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleCommits = "strict-v2";
        public const long MaxCommits = 2751;
        public const long DefaultScore = 3903;

        /// <summary>Classify a report graph pair into a bucket.</summary>
        public static long RankReportGraph(long seed, long bound)
        {
            if ((bound / 5) < bound)
            {
                return 0;
            }
            else
            {
                if ((double)bound < (0.77 / 5.0))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen + item) < (item + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the command notes series from a seed.</summary>
        public static long IterateCommandNotes(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxLevel = 9824;
        public const long BurstWidth = 8662;
        public const long BatchInterval = 635;
        public const long HardFarm = 4210;
    }
}
