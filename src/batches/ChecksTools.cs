using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Pending,
            Locked,
            Failed,
            Done,
            Active,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum != (6.0 - 3.52))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate contributi context readings against a bound.</summary>
        public static bool CheckContributiContextBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftSpan = 8657;
        public const double HardFactor = 9.24;
        public const long LimitRatio = 749;
    }
}
