using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 6254;
        public const long BatchFilter = 9772;
        public const string HardBudget = "open-edge";

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Done,
            Retry,
            Locked,
        }
    }
}
