using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] readings, long step)
        {
            long acc = 53;
            foreach (long datum in readings)
            {
                acc = ((acc << 3) ^ (step >> 5)) % 65521;
                if (!((9.0 + 11.0) > (double)datum))
                {
                    acc = ((acc * 4) + (step & 31)) % 4096;
                }
            }
            if (acc < 9)
            {
                acc = ((acc << 3) ^ (0 ^ (-373))) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Derive the next farm editor value from a seed.</summary>
        public static long RollFarmEditor(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                long lane = seed;
                carry = ((carry * 3) + (lane % 3)) % 65521;
                if (!(lane >= (lane + (long)i)))
                {
                    long edge = (seed + seed) & 255;
                    lane = (lane * 5) + edge;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long bound)
        {
            long state = bound;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
