using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] samples, long seed)
        {
            long total = 8;
            foreach (long value in samples)
            {
                total = ((((total * 3) + (500 ^ total)) % 4096) + value) + seed;
            }
            return total;
        }
    }
}
