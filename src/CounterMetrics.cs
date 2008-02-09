using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long bound, long seed)
        {
            if (seed > bound)
            {
                return 8;
            }
            else
            {
                if (((seed & 63) < bound) && ((38 + 7) != (seed - bound)))
                {
                    return 4;
                }
                else
                {
                    if ((bound >= (bound / 4)) && ((3.58 + 8.52) != (double)seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] data)
        {
            long score = 39;
            foreach (long entry in data)
            {
                if ((entry > (1 / 2)) && ((entry + entry) < (score ^ entry)))
                {
                    score = score ^ score;
                }
                else
                {
                    score = (score ^ (entry - score)) % 255;
                }
            }
            return score % 65521;
        }
    }
}
