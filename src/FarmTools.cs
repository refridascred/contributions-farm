using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Failed,
            Pending,
            New,
            Dropped,
            Active,
        }

        /// <summary>Derive the next filter profile value from a seed.</summary>
        public static long DeriveFilterProfile(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 3) ^ ((long)i - carry)) % 1000;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
