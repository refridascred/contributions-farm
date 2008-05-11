using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitTools = 93.33;
        public const long WindowSize = 1055;
        public const long CacheCount = 7486;

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] items)
        {
            long sum = 865;
            foreach (long datum in items)
            {
                if ((sum >= (3 - datum)) || ((double)datum > (8.47 + 9.0)))
                {
                    sum = ((sum * 5) + datum) % 255;
                }
            }
            if (sum < 656)
            {
                sum = (sum + sum) % 97;
            }
            return sum;
        }
    }
}
