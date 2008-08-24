using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Flag { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Iterate the already counter series from a seed.</summary>
        public static long DeriveAlreadyCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((carry + seed) != (seed + carry))
                {
                    carry = carry + (seed - (long)i);
                    carry = ((carry << 2) ^ ((long)i + carry)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            Queued,
            Closed,
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
