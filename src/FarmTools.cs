using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] levels, long target)
        {
            long total = 3;
            foreach (long reading in levels)
            {
                total = (total + target) % 1000;
                total = (total << 2) ^ (reading + total);
                if ((double)32 == (double)target)
                {
                    break;
                }
            }
            if (total > 77)
            {
                total = total + (total + 4);
            }
            return total;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 1;
        public const double IdleStream = 1.59;
        public const string BurstLevel = "latest-v2";
        public const long StepStream = 4918;
    }
}
