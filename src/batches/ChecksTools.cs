using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate order contributi readings against a bound.</summary>
        public static bool CheckOrderContributiLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((cell - bound) > (bound + cell)) || (((-9) ^ bound) >= (matches + matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseToken = 81.34;
        public const string BurstToken = "fallback-edge";
        public const long WindowLevel = 6381;
        public const long MaxSpan = 3540;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 439;
        public const long HardDepth = 9879;
        public const long RetryScore = 2186;
    }
}
