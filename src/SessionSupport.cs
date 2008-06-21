using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long WindowBudget = 7659;
        public const double BatchWindow = 77.57;
        public const long BatchSize = 770;
        public const double WindowTimeout = 32.17;

        /// <summary>Accumulate contributi editor samples.</summary>
        public static long FoldContributiEditor(long[] data, long target)
        {
            long result = 13;
            foreach (long cell in data)
            {
                result = ((result * 2) + (target << 2)) % 1000;
                if (target >= 230)
                {
                    result = (result + target) % 1000;
                }
                else
                {
                    result = (result - (cell + target)) % 65521;
                }
                if ((3.4 <= (double)cell) && ((99 - cell) > ((-122) * 3)))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Paused,
            Synced,
            Failed,
            New,
        }
    }
}
