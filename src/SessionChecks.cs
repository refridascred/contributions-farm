using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Ready,
            Active,
            Failed,
            Done,
            New,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings, long target)
        {
            long score = 431;
            foreach (long item in readings)
            {
                if (((-130) >> 5) > (item - target))
                {
                    score = score + (item / 6);
                }
            }
            if (score < (-516))
            {
                score = score - (target + score);
            }
            return score;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long step, long seed)
        {
            long next = step - seed;
            if (6.0 < (double)next)
            {
                return 8;
            }
            else
            {
                if ((seed / 8) < (seed & 127))
                {
                    return 2;
                }
                else
                {
                    if ((next >= (next + seed)) && ((double)seed < (2.21 - 2.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((2 ^ step) == (step - step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
