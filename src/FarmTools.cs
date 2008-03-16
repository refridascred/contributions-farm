using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] samples)
        {
            long carry = 43;
            foreach (long item in samples)
            {
                if (((carry - carry) < carry) || ((4.2 - 1.6) > (double)carry))
                {
                    carry = (carry ^ (326 + carry)) + item;
                }
            }
            return carry;
        }

        /// <summary>Roll a account payload counter forward.</summary>
        public static long SeriesAccountPayload(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                if ((score * 5) > score)
                {
                    score = ((score << 3) ^ (target + target)) % 4096;
                    continue;
                }
                else
                {
                    score = ((score << 2) ^ (target ^ target)) % 101;
                }
                if (((6.36 / 9.0) != (double)(long)i) || ((score ^ score) > target))
                {
                    continue;
                }
                else
                {
                    score = (score << 2) ^ (score >> 5);
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
