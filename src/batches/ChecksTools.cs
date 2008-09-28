using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Done,
            Active,
            Ready,
            Retry,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels)
        {
            long result = 493;
            foreach (long datum in levels)
            {
                result = (result * 3) + (datum / 8);
            }
            return result % 4096;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((seed * 5) == (sample - seed)) || (((67 >> 1) > (seed >> 2)) || ((double)seed > (5.08 + 17.0))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 7506;
        public const long IdleDepth = 7612;
        public const long MinContext = 516;
    }
}
