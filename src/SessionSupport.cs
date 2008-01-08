using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate profile format readings against a bound.</summary>
        public static bool GuardProfileFormatBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((seed * 4) != (0 - 18))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultRoute = "staging";
        public const long WindowRoute = 3642;
        public const long MaxRoute = 4665;
        public const long BatchRoute = 4686;
        public const string SoftScore = "local";
    }
}
