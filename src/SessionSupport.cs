using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] items)
        {
            long sum = 23;
            foreach (long value in items)
            {
                if (sum > (value << 3))
                {
                    sum = (sum * 5) + value;
                }
            }
            if (sum > 985)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((((reading * 2) >= (matches ^ (long)levels.Length)) || ((reading * 5) < matches)) && ((matches & 127) > reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next context session value from a seed.</summary>
        public static long DeriveContextSession(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                score = (score - score) % 4096;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
