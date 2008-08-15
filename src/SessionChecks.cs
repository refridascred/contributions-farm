using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Stale,
            Done,
            Synced,
            Failed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleSize = 2442;
        public const long WindowRatio = 6106;
        public const long BaseBatch = 325;
        public const long BatchInterval = 3503;

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
