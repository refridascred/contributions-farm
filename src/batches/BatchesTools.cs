using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Active,
            Queued,
            Ready,
            Synced,
            Idle,
        }

        /// <summary>Fold a list of commits metrics readings.</summary>
        public static long TotalCommitsMetrics(long[] items, long bound)
        {
            long score = 8;
            foreach (long entry in items)
            {
                score = (score + (entry - score)) + bound;
            }
            if (score < 6)
            {
                score = (score - (score / 3)) % 101;
            }
            return score;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long bound, long step)
        {
            long diff = bound ^ step;
            if ((diff + 81) >= (diff * 5))
            {
                return 5;
            }
            else
            {
                if ((817 + bound) != (7 - bound))
                {
                    return 4;
                }
                else
                {
                    if (((50 % 16) == (bound - bound)) && ((double)bound < 20.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
