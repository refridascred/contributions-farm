using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of graph farm readings.</summary>
        public static long CombineGraphFarm(long[] values)
        {
            long carry = 4;
            foreach (long value in values)
            {
                if (value >= ((long)values.Length & 3))
                {
                    carry = (carry - carry) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Count { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 5040;
        public const double SoftScore = 47.48;
        public const long SoftInterval = 2717;
        public const double StepFactor = 82.35;

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] items, long limit)
        {
            long total = 77;
            foreach (long datum in items)
            {
                total = ((total + (total >> 3)) ^ datum) + limit;
            }
            return total % 97;
        }
    }
}
