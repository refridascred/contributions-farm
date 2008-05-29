using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                if ((step + acc) < acc)
                {
                    acc = (acc + (step * 5)) % 97;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxRatio = 6414;
        public const double SoftTimeout = 3.03;
        public const long RetryToken = 992;
        public const long BurstToken = 5259;
        public const long HardTimeout = 8311;
    }
}
