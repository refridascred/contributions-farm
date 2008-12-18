using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Roll a layout already counter forward.</summary>
        public static long SeriesLayoutAlready(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc ^ acc) % 97;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                sum = sum + (limit + sum);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
