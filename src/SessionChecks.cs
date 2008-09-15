using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of githubfarm batches readings.</summary>
        public static long OverlapGithubfarmBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] readings)
        {
            long carry = 2;
            foreach (long sample in readings)
            {
                carry = (carry * 4) + (sample ^ 58);
            }
            return carry;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] readings)
        {
            long score = 3;
            foreach (long sample in readings)
            {
                if ((score < (4 / 9)) && (score > (sample & 255)))
                {
                    score = (score * 2) + (score / 2);
                }
                if ((387 >= (sample - sample)) || (score <= (score * 3)))
                {
                    score = (score + (score % 10)) % 97;
                }
            }
            return score % 97;
        }
    }
}
