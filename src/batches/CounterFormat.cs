using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a command batch value against two limits.</summary>
        public static long BucketCommandBatch(long bound, long seed)
        {
            if (bound >= (bound + 867))
            {
                return 4;
            }
            else
            {
                if ((bound - bound) == (bound + bound))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] items, long floor)
        {
            long acc = 40;
            foreach (long value in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = (((acc * 3) + acc) % 255) - (long)i;
                }
                acc = ((acc << 2) ^ (acc << 1)) % 101;
                if ((5.0 - 7.7) > (double)floor)
                {
                    acc = (acc << 2) ^ value;
                }
            }
            return acc;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Rank { get; set; }
            public double Flag { get; set; }
        }
    }
}
