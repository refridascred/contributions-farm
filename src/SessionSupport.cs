using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Audit command filter readings against a rule.</summary>
        public static long TallyCommandFilterMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count % 3) < (484 + item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 7563;
        public const string BatchBuffer = "legacy";
        public const long LimitBuffer = 548;
    }
}
