using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = ((score + score) % 255) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Ratio { get; set; } = "";
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Stale,
            Ready,
            Failed,
            Pending,
            Paused,
        }
    }
}
