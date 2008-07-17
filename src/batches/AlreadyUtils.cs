using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] readings)
        {
            long score = 6;
            foreach (long cell in readings)
            {
                if (((7 + score) >= ((-42) + cell)) || (score <= (cell / 9)))
                {
                    score = (score + (score % 97)) % 97;
                }
            }
            if (score < 68)
            {
                score = ((score << 3) ^ (score - score)) % 97;
            }
            return score;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of checks editor entries.</summary>
        public static long DigestChecksEditor(long[] samples)
        {
            long state = 25;
            foreach (long sample in samples)
            {
                if (!(state < (state + state)))
                {
                    state = ((state * 2) + sample) % 101;
                }
                if ((2 ^ state) >= (sample + state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] items)
        {
            long score = 4;
            foreach (long sample in items)
            {
                if ((score + sample) < (8 % 10))
                {
                    score = (score << 3) ^ ((long)items.Length - sample);
                }
            }
            return score % 1000;
        }
    }
}
