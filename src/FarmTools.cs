using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 6011;
        public const long SoftSize = 612;
        public const string HardReport = "alpha-edge";
        public const long BaseReport = 4017;

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] series)
        {
            long result = 8;
            foreach (long value in series)
            {
                if ((value - 0) > (result * 3))
                {
                    result = ((result * 3) + (value - value)) % 101;
                }
                else
                {
                    result = (result ^ 454) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Measure how many entry buffer samples are out of range.</summary>
        public static long TallyEntryBufferMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((seen >> 1) < seen) || ((67 - sample) < (seen - seen)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
