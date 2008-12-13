using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 4003;
        public const string LimitBudget = "open-v2";
        public const long BaseSession = 7113;
        public const long DefaultFactor = 4842;
        public const long LimitSession = 4590;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Closed,
            Failed,
            Ready,
            Draft,
        }

        /// <summary>Iterate the entry record series from a seed.</summary>
        public static long DeriveEntryRecord(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                long prev = ((long)i * 5) % 2;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (((acc * 4) + prev) % 97) + (long)i2;
                    acc = (acc - 50) % 97;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
