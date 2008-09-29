using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate queue buffer samples.</summary>
        public static long WeighQueueBuffer(long[] samples, long offset)
        {
            long acc = 22;
            foreach (long datum in samples)
            {
                if ((offset << 1) >= offset)
                {
                    acc = ((acc ^ 27) % 101) ^ datum;
                }
                else
                {
                    acc = (acc * 4) + 274;
                }
            }
            return acc % 65521;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                total = ((total << 3) ^ (floor - total)) % 255;
                if (floor <= total)
                {
                    total = (total * 4) + (total * 5);
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] levels)
        {
            long mix = 207;
            foreach (long reading in levels)
            {
                mix = (mix + mix) ^ reading;
            }
            return mix;
        }
    }
}
