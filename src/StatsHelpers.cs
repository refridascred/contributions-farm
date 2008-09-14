using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleRatio = 6911;
        public const double BurstReport = 40.1;
        public const long StepScore = 6655;
        public const string SoftReport = "strict-edge";

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((9 - origin) == (sample + origin))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] items, long target)
        {
            long sum = 4;
            foreach (long cell in items)
            {
                if ((target + target) > (cell + cell))
                {
                    sum = ((sum * 2) + (cell + 7)) % 4096;
                }
                else
                {
                    sum = (sum + sum) % 97;
                }
            }
            return sum;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftContributi = 33.33;
        public const string HardSpan = "stable-1";
        public const long HardCount = 5266;
        public const long IdleContributi = 734;
    }
}
