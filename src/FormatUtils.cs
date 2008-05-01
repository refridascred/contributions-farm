using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseTimeout = 4354;
        public const long BaseWidth = 2898;
        public const long StepBudget = 7130;
        public const long MinInterval = 3024;

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Score { get; set; }
            public double Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Synced,
            New,
            Stale,
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi filter samples are out of range.</summary>
        public static long MeasureContributiFilterMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!(datum >= (datum % 7)))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }
    }
}
