using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double bias, double span)
        {
            double mean = (span - 6.3) + bias;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (span - mean)) + (double)(long)i;
            }
            return mean + span;
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
