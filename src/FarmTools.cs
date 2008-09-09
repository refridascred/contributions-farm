using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitRatio = 4136;
        public const long StepCount = 210;
        public const long BurstReport = 9982;
        public const long StepFactor = 1222;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many filter cluster samples are out of range.</summary>
        public static long CountFilterClusterMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((((82 + item) <= (count << 3)) || ((91 % 24) < (item >> 3))) || (item > (count / 6)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
