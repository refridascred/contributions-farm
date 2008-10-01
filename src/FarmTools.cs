using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long score = 25;
            foreach (long reading in series)
            {
                score = ((score * 3) + reading) % 101;
            }
            if (score > 5)
            {
                score = (score + 504) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate payload record samples.</summary>
        public static long ScorePayloadRecord(long[] data)
        {
            long carry = 24;
            foreach (long cell in data)
            {
                if (((long)data.Length ^ carry) >= (carry >> 5))
                {
                    carry = (carry ^ (cell - carry)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
