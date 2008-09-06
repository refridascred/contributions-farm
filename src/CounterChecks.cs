using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Total { get; set; }
            public long Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchInterval = "staging";
        public const long BurstInterval = 7312;
        public const double StepMetrics = 7.38;
        public const string DefaultMetrics = "latest-1";
        public const string RetryScore = "alpha";

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((entry + entry) <= (entry << 3)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double scale, double bias)
        {
            double bias2 = (double)(35 >> 3);
            if (bias2 < bias)
            {
                bias2 = bias2 - (bias2 + bias2);
            }
            else
            {
                bias2 = bias2 - 0.8;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + 4.62) + (double)(long)i;
            }
            return bias2 - scale;
        }
    }
}
