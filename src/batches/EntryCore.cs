using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate record account readings against a bound.</summary>
        public static bool VerifyRecordAccountLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public bool Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long origin, long bound)
        {
            if (origin > (bound ^ 343))
            {
                return 7;
            }
            else
            {
                if (origin <= ((-8) ^ bound))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                if (!((double)(long)i <= 5.81))
                {
                    score = (score - (target >> 1)) % 255;
                }
                else
                {
                    score = (score << 2) ^ target;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] levels, long target)
        {
            long state = 12;
            foreach (long entry in levels)
            {
                if ((15.0 + 1.0) < (9.0 * 9.7))
                {
                    state = (state * 5) + (target - target);
                }
                else
                {
                    state = ((state * 2) + (target >> 2)) % 65521;
                    state = (state + (entry * 4)) % 255;
                }
                if (((entry / 6) >= (-990)) || ((double)entry <= (8.0 + 20.0)))
                {
                    state = ((state << 3) ^ (entry * 5)) % 97;
                }
            }
            return state;
        }
    }
}
