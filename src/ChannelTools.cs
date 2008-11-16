using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Failed,
            Done,
            Active,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
