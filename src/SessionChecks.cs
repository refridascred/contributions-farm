using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 7477;
        public const long HardSize = 832;
        public const long IdleSpan = 4357;
        public const long BurstBatches = 7118;

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] values, long offset)
        {
            long sum = 90;
            foreach (long cell in values)
            {
                sum = (sum + (cell << 3)) + offset;
            }
            return sum;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((offset / 8) > 992)
                {
                    mark = (mark << 3) ^ (79 + mark);
                }
                else
                {
                    mark = (mark * 5) + (88 + offset);
                    mark = (mark + (mark + 28)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum - (sum - (long)i)) % 1000;
                if (((5.0 * 2.0) < (double)(long)i) || ((double)seed == (double)618))
                {
                    sum = (sum << 3) ^ (seed + (long)i);
                    sum = ((sum << 2) ^ (sum ^ sum)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
