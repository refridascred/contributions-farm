using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double bias, double bias2)
        {
            double drift = bias2 / 7.0;
            if (drift >= 6.0)
            {
                drift = drift + (double)69;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                score = score ^ (target + score);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
