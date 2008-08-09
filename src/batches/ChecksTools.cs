using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] series, long step)
        {
            long mark = 392;
            foreach (long datum in series)
            {
                mark = ((mark ^ (step << 1)) % 101) - datum;
                if ((47 + (-36)) > (long)series.Length)
                {
                    break;
                }
            }
            return mark;
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
