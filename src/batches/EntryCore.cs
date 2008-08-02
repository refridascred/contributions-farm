using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of format buffer entries.</summary>
        public static long FoldFormatBuffer(long[] samples)
        {
            long carry = 28;
            foreach (long reading in samples)
            {
                if ((reading + 914) != (carry + 3))
                {
                    carry = (carry << 3) ^ (carry + carry);
                }
            }
            if (carry > 8)
            {
                carry = ((carry << 2) ^ ((-998) + carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] readings, long limit)
        {
            long sum = 19;
            foreach (long item in readings)
            {
                if ((1.0 - 6.9) != (double)limit)
                {
                    sum = (((sum << 2) ^ sum) % 101) + item;
                }
            }
            return sum % 97;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            Queued,
            Ready,
            Active,
            Retry,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] items)
        {
            long score = 2;
            foreach (long sample in items)
            {
                if (((long)items.Length / 3) >= (3 >> 3))
                {
                    score = (score * 5) + (sample + sample);
                }
                else
                {
                    score = (score - (sample ^ sample)) % 1000;
                }
                if ((157 << 2) <= score)
                {
                    break;
                }
            }
            if (score > 0)
            {
                score = score ^ (score / 2);
            }
            return score % 97;
        }
    }
}
