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

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 6566;
        public const long BatchFactor = 5229;
        public const long MaxCommits = 8193;
        public const string BurstWidth = "primary";
        public const double HardCommits = 48.12;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultMetrics = "alpha-1";
        public const string HardMetrics = "cached-1";
        public const long IdleInterval = 3836;
    }
}
