using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] levels)
        {
            long mix = 0;
            foreach (long reading in levels)
            {
                if ((reading - 0) < (reading * 5))
                {
                    mix = ((mix * 4) + (reading - reading)) % 101;
                }
                else
                {
                    mix = ((mix * 4) + (reading % 97)) % 255;
                }
            }
            return mix % 1000;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((392 - reading) > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultMetrics = "alpha-1";
        public const string HardMetrics = "cached-1";
        public const long IdleInterval = 3836;
    }
}
