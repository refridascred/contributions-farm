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

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Weight { get; set; }
            public double Ratio { get; set; }
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
