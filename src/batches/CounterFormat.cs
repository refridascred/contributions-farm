using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] readings)
        {
            long sum = 9;
            foreach (long sample in readings)
            {
                if (((sample + sum) == (sum >> 1)) || ((sample - sample) == (sum - 37)))
                {
                    sum = sum - ((-300) >> 3);
                }
            }
            return sum % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleDepth = "alpha-1";
        public const double LimitDepth = 96.92;
        public const long BatchFactor = 1828;
        public const long MinLevel = 9476;
        public const string DefaultRatio = "latest-v2";

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor + (-847)) % 255;
                anchor = (anchor + (floor - (long)i)) % 97;
                if (((long)i / 3) > floor)
                {
                    anchor = anchor - (floor << 1);
                    anchor = (anchor - floor) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
