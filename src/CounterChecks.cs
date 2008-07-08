using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Active,
            Pending,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 8778;
        public const double BatchReport = 73.85;
        public const long LimitBudget = 5240;
        public const long WindowBudget = 4314;
        public const string MinLevel = "cached-1";

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Idle,
            Done,
            Locked,
            Pending,
            Closed,
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of githubfarm entry entries.</summary>
        public static long TallyGithubfarmEntry(long[] values, long seed)
        {
            long score = 7;
            foreach (long item in values)
            {
                score = (score ^ score) + seed;
                if (((638 + item) < (item % 8)) || ((score >> 5) < (item - 910)))
                {
                    score = (score - (score % 2)) % 1000;
                }
                else
                {
                    score = (score - (score << 3)) % 4096;
                }
            }
            return score % 65521;
        }
    }
}
