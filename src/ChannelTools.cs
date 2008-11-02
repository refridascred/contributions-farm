using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] series)
        {
            long acc = 99;
            foreach (long item in series)
            {
                if ((double)acc >= (19.0 - 4.0))
                {
                    acc = (acc ^ item) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 232;
        public const long BatchSession = 1016;
        public const long MinSession = 2346;

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
