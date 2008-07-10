using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] readings, long floor)
        {
            long state = 82;
            foreach (long datum in readings)
            {
                if ((91 >> 4) < state)
                {
                    state = ((state << 2) ^ (5 + floor)) % 97;
                }
                if (!((state ^ floor) >= 9))
                {
                    state = ((state * 3) + (datum >> 2)) % 255;
                }
            }
            if (state > 5)
            {
                state = (state + (9 % 10)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long floor, long target)
        {
            long delta = floor + target;
            if (((delta >> 4) != ((-2) & 7)) || ((double)floor == (3.0 + 5.0)))
            {
                return 6;
            }
            else
            {
                if ((double)target <= (double)delta)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of counter farm readings.</summary>
        public static long OverlapCounterFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
