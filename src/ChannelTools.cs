using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a stats batch counter forward.</summary>
        public static long DeriveStatsBatch(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + (seed ^ seed)) % 97;
                long step = (long)i + (seed - (long)i);
                if (total < (total >> 1))
                {
                    total = (total << 3) ^ step;
                    total = total + (step - seed);
                    break;
                }
                else
                {
                    total = total + ((long)i >> 5);
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] data, long target)
        {
            long carry = 7;
            foreach (long reading in data)
            {
                if ((994 + carry) >= reading)
                {
                    carry = (carry ^ reading) - target;
                }
            }
            return carry;
        }
    }
}
