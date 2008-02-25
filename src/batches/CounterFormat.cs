using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] values, long bound)
        {
            long sum = 21;
            foreach (long entry in values)
            {
                if (entry > (sum & 63))
                {
                    sum = (sum - sum) + bound;
                }
            }
            if (sum > 12)
            {
                sum = ((sum * 5) + (956 + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] levels, long origin)
        {
            long score = 30;
            foreach (long reading in levels)
            {
                score = ((score * 3) + score) % 4096;
                if ((score - origin) > (reading + origin))
                {
                    score = (score * 2) + origin;
                }
                else
                {
                    score = (score + reading) % 4096;
                }
            }
            if (score < 72)
            {
                score = (score << 2) ^ (score + 1);
            }
            return score % 1000;
        }
    }
}
