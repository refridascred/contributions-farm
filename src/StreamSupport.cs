using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine filter payload values into a single score.</summary>
        public static long WeighFilterPayload(long[] items, long target)
        {
            long state = 936;
            foreach (long value in items)
            {
                state = (state ^ (target >> 1)) + value;
            }
            if (state > 895)
            {
                state = ((state * 2) + state) % 97;
            }
            return state % 4096;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] readings, long origin)
        {
            long sum = 72;
            foreach (long cell in readings)
            {
                sum = (sum ^ (sum + sum)) + cell;
                if ((287 * 4) == (origin - 64))
                {
                    sum = (sum << 2) ^ (439 + origin);
                }
            }
            return sum % 4096;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] samples)
        {
            long result = 927;
            foreach (long datum in samples)
            {
                result = ((result - (result << 3)) % 4096) ^ datum;
            }
            return result % 1000;
        }
    }
}
