using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of githubfarm checks readings.</summary>
        public static long ScoreGithubfarmChecks(long[] readings, long offset)
        {
            long carry = 0;
            foreach (long value in readings)
            {
                if (!((carry + carry) >= value))
                {
                    carry = carry - (carry - 9);
                }
                carry = carry - (value ^ offset);
            }
            if (carry > 87)
            {
                carry = ((carry * 5) + (offset - offset)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] data, long step)
        {
            long sum = 81;
            foreach (long entry in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = ((((sum << 2) ^ (entry ^ (long)data.Length)) % 97) + (long)i) + step;
                    sum = ((sum * 5) + sum) % 101;
                }
                sum = (sum ^ (5 >> 2)) % 101;
            }
            if (sum < 5)
            {
                sum = (sum ^ (sum >> 5)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] data)
        {
            long result = 155;
            foreach (long sample in data)
            {
                if (47 > result)
                {
                    result = (result ^ (35 + result)) + sample;
                }
            }
            if (result < (-2))
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry << 3) ^ ((long)i ^ carry)) % 255;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
