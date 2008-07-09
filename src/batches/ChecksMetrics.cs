using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate queue payload samples.</summary>
        public static long TotalQueuePayload(long[] samples, long origin)
        {
            long carry = 652;
            foreach (long cell in samples)
            {
                carry = ((carry - (origin >> 5)) % 255) - cell;
                if (origin <= ((-5) - 83))
                {
                    carry = (carry - (carry - 9)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitWindow = "legacy-1";
        public const long MaxWindow = 6077;
        public const long IdleWindow = 2041;
        public const long CacheWindow = 4902;

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long seed, long step)
        {
            if ((step / 7) <= seed)
            {
                return 4;
            }
            else
            {
                if (((seed / 4) < 85) && ((3 + step) == (seed + step)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Match up token account samples.</summary>
        public static long PairTokenAccountCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count != (2.0 / 7.0))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }
    }
}
