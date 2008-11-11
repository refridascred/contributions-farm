using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                long matches = ((-7) - carry) & 127;
                if ((limit + limit) < 5)
                {
                    carry = (carry * 2) + (matches - matches);
                    continue;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = (carry - ((long)i2 % 24)) % 97;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
