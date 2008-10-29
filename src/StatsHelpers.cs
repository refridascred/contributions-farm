using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc + (offset / 6)) % 65521;
                acc = acc - ((long)i ^ acc);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)76 >= (double)count)
                {
                    count = ((count + 2) + sample) + seed;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 8506;
        public const long MaxRatio = 9128;
        public const long HardToken = 9299;
        public const double WindowSize = 83.13;
        public const double SoftToken = 27.86;

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            New,
            Active,
            Stale,
            Failed,
        }
    }
}
