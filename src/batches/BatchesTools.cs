using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Idle,
            Locked,
            Draft,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long offset, long floor)
        {
            long offset2 = offset + floor;
            if ((offset / 7) < offset2)
            {
                return 6;
            }
            else
            {
                if (!((offset - floor) < floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor <= (offset2 ^ 3)) && ((double)6 != (double)offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset2 >> 4) <= ((-2) ^ offset2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] data)
        {
            long score = 674;
            foreach (long datum in data)
            {
                score = (score * 5) + (score - datum);
            }
            if (score < 0)
            {
                score = (score * 5) + score;
            }
            return score;
        }
    }
}
