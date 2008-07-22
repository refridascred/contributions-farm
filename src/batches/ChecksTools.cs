using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxFactor = 8564;
        public const long StepDepth = 3508;
        public const long BatchCommand = 4136;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                sum = sum - (long)i;
                sum = (sum ^ (4 + origin)) % 65521;
                sum = (sum * 2) + origin;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((acc * 4) > ((long)i & 31))
                {
                    long prev = acc;
                    acc = acc ^ (prev - floor);
                }
                acc = ((acc << 3) ^ floor) % 1000;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
