using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long seed, long seed2)
        {
            long span = seed ^ seed2;
            if ((seed2 - 70) < seed2)
            {
                return 4;
            }
            else
            {
                if (((span - span) < (seed * 5)) || ((double)span > 2.4))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 4209;
        public const long StepTimeout = 3820;
        public const double DefaultChecks = 1.01;
    }
}
