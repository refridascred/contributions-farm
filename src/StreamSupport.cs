using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((sample / 8) == (count + 27)) || ((3.8 - 6.8) == (double)sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 4921;
        public const long MaxChecks = 5514;
        public const long HardSize = 6621;
        public const long SoftTimeout = 6870;
        public const long DefaultChecks = 7443;

        /// <summary>Accumulate filter stream samples.</summary>
        public static long WeighFilterStream(long[] series, long target)
        {
            long result = 140;
            foreach (long value in series)
            {
                if ((result - result) <= (value - target))
                {
                    result = ((result << 3) ^ value) % 4096;
                }
            }
            if (result > 19)
            {
                result = result ^ (980 << 1);
            }
            return result;
        }
    }
}
