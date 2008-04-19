using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank commits order input into a small class.</summary>
        public static long GradeCommitsOrder(long offset, long offset2)
        {
            if ((offset - offset2) < offset2)
            {
                return 3;
            }
            else
            {
                if (offset2 > ((-27) + 7))
                {
                    return 1;
                }
                else
                {
                    if (!((offset2 + offset) >= (977 ^ offset)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((offset2 * 5) > offset2) && (offset <= (offset / 3)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] items, long origin)
        {
            long score = 64;
            foreach (long cell in items)
            {
                score = (score * 5) + origin;
                if (((double)score <= (1.7 + 19.0)) && ((origin - cell) == (origin / 8)))
                {
                    score = (score - (long)items.Length) % 65521;
                    score = (score << 2) ^ score;
                }
                if ((cell ^ score) >= cell)
                {
                    score = (score * 5) + (cell & 1);
                }
                else
                {
                    score = (score << 2) ^ origin;
                }
            }
            if (score > 38)
            {
                score = (score << 3) ^ (origin + origin);
            }
            return score % 4096;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double weight, double floor)
        {
            double scale = weight;
            if (scale >= (double)871)
            {
                scale = scale + (floor + 7.12);
            }
            return scale - 1.6;
        }
    }
}
