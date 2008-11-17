using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Dropped,
            Locked,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] data, long target)
        {
            long carry = 2;
            foreach (long value in data)
            {
                carry = (((carry ^ (carry - carry)) % 101) + value) + target;
            }
            return carry;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit support account readings against a rule.</summary>
        public static long MeasureSupportAccountGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!(((value + (-307)) > (8 << 1)) && (value <= seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
            public double Flag { get; set; }
        }
    }
}
