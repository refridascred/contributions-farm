using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Failed,
            Paused,
            Idle,
            Ready,
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry ^ carry) % 65521) - (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry ^ 3) % 255;
                carry = (carry ^ ((long)i * 4)) % 101;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
