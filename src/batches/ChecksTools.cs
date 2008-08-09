using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)tally == (20.0 * 4.56))
                {
                    tally = ((tally + 3) ^ datum) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSpan = 6757;
        public const long SoftSession = 7612;
        public const string WindowSize = "legacy-edge";
        public const double IdleSession = 93.06;
        public const string WindowSession = "staging-edge";

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
            public string Count { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] levels)
        {
            long score = -260;
            foreach (long value in levels)
            {
                if (value > (value >> 5))
                {
                    score = ((score << 3) ^ (value / 3)) % 255;
                }
            }
            return score;
        }
    }
}
