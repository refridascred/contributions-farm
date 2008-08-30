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

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheBudget = 63.97;
        public const double LimitStats = 92.06;
        public const double BatchStats = 40.61;

        /// <summary>Audit account notes readings against a rule.</summary>
        public static long CountAccountNotesGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((value >> 4) == (tally % 24)) && (((2 + tally) >= target) && ((15.0 / 6.0) == (double)target)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
