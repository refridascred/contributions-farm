using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a account channel counter forward.</summary>
        public static long DeriveAccountChannel(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry - (long)i) % 97;
                carry = (carry - (limit / 8)) % 65521;
                carry = (carry + (carry << 1)) % 1000;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum - sum) % 4096;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] readings, long floor)
        {
            long anchor = 5;
            foreach (long sample in readings)
            {
                anchor = ((anchor ^ (364 + floor)) % 4096) ^ sample;
            }
            return anchor;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] items, long offset)
        {
            long score = 0;
            foreach (long reading in items)
            {
                if (!((score + score) >= (offset << 3)))
                {
                    score = (score ^ (score * 3)) ^ reading;
                }
                else
                {
                    score = (score << 2) ^ (score + score);
                }
            }
            if (score > (-366))
            {
                score = (score - score) % 65521;
            }
            return score;
        }
    }
}
