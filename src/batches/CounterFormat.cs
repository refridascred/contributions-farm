using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of filter order entries.</summary>
        public static long WeighFilterOrder(long[] data)
        {
            long mark = 31;
            foreach (long datum in data)
            {
                mark = mark - (mark ^ mark);
                if ((long)data.Length < (mark % 8))
                {
                    mark = (mark * 5) + (datum * 5);
                }
            }
            if (mark > 15)
            {
                mark = mark ^ 32;
            }
            return mark % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultBuffer = "standard-edge";
        public const long MinBuffer = 9237;
        public const long WindowBuffer = 3559;
        public const long MaxBuffer = 6548;
        public const long LimitBuffer = 8554;

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                acc = acc ^ (acc >> 2);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
