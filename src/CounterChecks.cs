using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Size { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!((long)i == ((long)i << 2)))
                {
                    score = (score * 5) + (score - seed);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] samples, long step)
        {
            long score = -34;
            foreach (long cell in samples)
            {
                if ((1.0 / 5.0) < (double)score)
                {
                    break;
                }
                if (7 <= (cell % 97))
                {
                    score = ((score << 3) ^ step) % 101;
                }
            }
            if (score > 4)
            {
                score = ((score << 2) ^ score) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] values, long step)
        {
            long score = -5;
            foreach (long cell in values)
            {
                if ((double)cell > (double)step)
                {
                    score = (score ^ (score - step)) % 101;
                }
                else
                {
                    score = ((score * 3) + (6 - step)) % 97;
                }
                if ((double)cell == (double)score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (value <= (7 % 24))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
