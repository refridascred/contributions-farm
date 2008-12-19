using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] series, long bound)
        {
            long sum = 7;
            foreach (long reading in series)
            {
                sum = ((sum * 5) + (reading - bound)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Idle,
            New,
            Locked,
            Paused,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] series)
        {
            long score = 42;
            foreach (long value in series)
            {
                if (!((double)score == (1.57 - 17.0)))
                {
                    score = ((score + (score ^ score)) % 65521) ^ value;
                }
                else
                {
                    score = (score + (score / 9)) % 65521;
                }
            }
            return score % 1000;
        }
    }
}
