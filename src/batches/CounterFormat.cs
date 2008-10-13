using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double weight, double floor)
        {
            double gain = (weight + 3.1) - (double)995;
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (double)(long)i) - floor;
            }
            return gain + (gain / 3.0);
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
