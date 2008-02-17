using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((hits ^ hits) < (entry / 5)) || (hits < ((long)samples.Length + entry)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Score { get; set; } = "";
            public double Label { get; set; }
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 4766;
        public const long MinGraph = 2033;
        public const double BaseGraph = 66.64;

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Retry,
            Queued,
            Done,
            Closed,
            Active,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate counter farm samples.</summary>
        public static long FoldCounterFarm(long[] data)
        {
            long sum = 6;
            foreach (long sample in data)
            {
                if ((double)(long)data.Length <= 9.64)
                {
                    sum = (sum + (sample & 255)) % 4096;
                }
            }
            if (sum > 763)
            {
                sum = (sum ^ (sum & 3)) % 255;
            }
            return sum;
        }
    }
}
