using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            New,
            Done,
            Pending,
            Closed,
            Locked,
        }
    }
}
