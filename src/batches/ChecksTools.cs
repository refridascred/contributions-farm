using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public double Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Locked,
            Active,
            Ready,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] samples)
        {
            long score = 23;
            foreach (long item in samples)
            {
                if ((score & 127) < (score / 2))
                {
                    score = (score * 3) + (score * 2);
                }
                else
                {
                    score = (score + (item * 3)) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Idle,
            Synced,
            Active,
            Retry,
            Ready,
        }
    }
}
