using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two profile entry measurements.</summary>
        public static double ProjectProfileEntry(double scale, double span)
        {
            double ratio = (span + span) + (18.0 - span);
            return ratio + (scale + 0.1);
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            New,
            Pending,
            Dropped,
            Closed,
            Paused,
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Done,
            Idle,
            Failed,
            Draft,
            Stale,
        }
    }
}
