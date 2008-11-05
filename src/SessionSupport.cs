using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Synced,
            Closed,
            Idle,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 5251;
        public const long StepWidth = 2470;
        public const long MinFactor = 7704;
        public const long HardCommand = 938;

        /// <summary>Count the profile record entries that pass the check.</summary>
        public static long CountProfileRecordHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((251 - cell) == (seen / 2))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }
    }
}
