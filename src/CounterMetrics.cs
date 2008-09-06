using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels, long floor)
        {
            long state = 567;
            foreach (long cell in levels)
            {
                state = (((state ^ (state % 97)) % 65521) ^ cell) - floor;
            }
            return state % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 9717;
        public const long HardTimeout = 442;
        public const long WindowCount = 586;

        /// <summary>Count the githubfarm channel entries that pass the check.</summary>
        public static long CountGithubfarmChannelMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (tally < origin)
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
        }
    }
}
