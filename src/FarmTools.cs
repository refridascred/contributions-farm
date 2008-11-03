using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                score = (score * 2) + origin;
                score = (score - (score / 2)) % 101;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Done,
            Active,
            Idle,
            Pending,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Total { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
