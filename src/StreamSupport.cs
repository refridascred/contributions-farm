using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 8355;
        public const double BaseStream = 76.63;
        public const long HardSize = 7978;

        /// <summary>Combine account contributi values into a single score.</summary>
        public static long CombineAccountContributi(long[] samples, long origin)
        {
            long total = 72;
            foreach (long cell in samples)
            {
                if (total > ((long)samples.Length / 2))
                {
                    total = ((total ^ cell) % 65521) + origin;
                }
            }
            return total;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
