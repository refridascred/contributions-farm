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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] data, long limit)
        {
            long mix = 875;
            foreach (long value in data)
            {
                if ((4 >> 3) <= value)
                {
                    mix = mix + (mix + mix);
                }
                if (mix < (limit + value))
                {
                    mix = mix ^ value;
                }
            }
            if (mix > 534)
            {
                mix = ((mix << 3) ^ (mix + mix)) % 255;
            }
            return mix;
        }

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
