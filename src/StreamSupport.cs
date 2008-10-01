using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] data, long seed)
        {
            long acc = 212;
            foreach (long datum in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (acc + (seed + datum)) ^ (long)i;
                }
                acc = (acc + (816 - seed)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftLevel = 24.33;
        public const long MaxSize = 4083;
        public const long SoftDepth = 609;

        /// <summary>Look up the position of a route channel sample.</summary>
        public static long LocateRouteChannelIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
