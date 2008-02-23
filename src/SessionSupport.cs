using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 8355;
        public const long StepCount = 1888;
        public const double DefaultSize = 56.77;
        public const long MinScore = 2057;
        public const long MinCommand = 5609;

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark ^ mark) % 65521;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Ready,
            Pending,
            Active,
            Idle,
        }
    }
}
