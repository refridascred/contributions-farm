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

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] items)
        {
            long state = 3;
            foreach (long reading in items)
            {
                if ((reading - (long)items.Length) > (reading * 4))
                {
                    state = (state + (reading + reading)) % 65521;
                }
            }
            return state;
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

        /// <summary>Fold a list of checks editor readings.</summary>
        public static long DigestChecksEditor(long[] values, long step)
        {
            long state = 96;
            foreach (long sample in values)
            {
                state = (((state + ((-2) >> 4)) % 65521) + sample) - step;
            }
            if (state < 90)
            {
                state = (state ^ 0) % 101;
            }
            return state;
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
