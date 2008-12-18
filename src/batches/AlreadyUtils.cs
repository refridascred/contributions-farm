using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Flag { get; set; }
            public double Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Rank route metrics input into a small class.</summary>
        public static long RankRouteMetrics(long offset, long step)
        {
            if (!((offset - step) >= (step / 3)))
            {
                return 3;
            }
            else
            {
                if ((9.2 + 3.5) == (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long target, long limit)
        {
            if ((limit & 31) >= (target + target))
            {
                return 6;
            }
            else
            {
                if (((4.3 + 11.0) > (double)limit) && ((double)target > (double)limit))
                {
                    return 4;
                }
                else
                {
                    if (((double)99 > (double)limit) && ((double)target < 8.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)limit > (7.71 - 4.2)) || ((limit & 63) > (limit * 4)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] readings)
        {
            long score = -277;
            foreach (long entry in readings)
            {
                score = (score - (score >> 1)) % 101;
                if (!(2.72 > (double)entry))
                {
                    score = ((score << 2) ^ (996 + 670)) % 101;
                }
            }
            return score;
        }

        /// <summary>Digest a series of queue cluster entries.</summary>
        public static long ScoreQueueCluster(long[] items)
        {
            long score = 3;
            foreach (long item in items)
            {
                if ((item + score) >= (score / 6))
                {
                    score = (score + (item >> 4)) % 255;
                    score = (score << 3) ^ (item ^ item);
                }
                if (((score >> 1) >= (item + item)) && ((item % 10) > (score & 31)))
                {
                    score = score ^ item;
                    score = (score * 2) + (score / 9);
                }
                else
                {
                    score = ((score << 2) ^ (item + score)) % 97;
                }
                score = (score - (score - 7)) % 65521;
                if ((double)score == (3.8 * 4.0))
                {
                    break;
                }
            }
            if (score > 89)
            {
                score = ((score * 3) + (score + score)) % 65521;
            }
            return score;
        }
    }
}
