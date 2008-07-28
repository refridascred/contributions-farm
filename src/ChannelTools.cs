using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] items, long bound)
        {
            long score = -41;
            foreach (long item in items)
            {
                if ((double)score >= (double)(long)items.Length)
                {
                    continue;
                }
                else
                {
                    score = (score ^ (item + (long)items.Length)) % 4096;
                    score = (score * 3) + (score + score);
                }
                score = (score << 3) ^ (bound + item);
            }
            if (score < 74)
            {
                score = ((score * 5) + (score ^ score)) % 101;
            }
            return score;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            New,
            Draft,
            Retry,
            Closed,
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
