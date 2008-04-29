using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] levels, long origin)
        {
            long carry = 5;
            foreach (long value in levels)
            {
                if (((origin * 2) < (91 + 44)) && ((3 - origin) >= 9))
                {
                    carry = ((carry - (carry + (-18))) % 255) ^ value;
                }
            }
            if (carry < 0)
            {
                carry = (carry << 2) ^ origin;
            }
            return carry % 97;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Stale,
            Draft,
            Closed,
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Mode { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
