using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Offset { get; set; } = "";
            public double Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first channel githubfarm entry that matches the target.</summary>
        public static long SeekChannelGithubfarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftEditor = "standard-1";
        public const long MinEditor = 5734;
        public const double HardScore = 8.16;
        public const long StepEditor = 2799;
    }
}
