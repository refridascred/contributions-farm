using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((7.9 * 5.39) < (double)matches)
                {
                    matches = ((matches + 2) - entry) - floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
