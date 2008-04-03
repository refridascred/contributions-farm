using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry - (limit + (long)i)) % 101;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long floor, long step)
        {
            long step2 = floor + step;
            if (step2 < step)
            {
                return 2;
            }
            else
            {
                if ((floor - 8) > floor)
                {
                    return 1;
                }
                else
                {
                    if ((double)floor >= (double)step2)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen < (seen >> 2))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
