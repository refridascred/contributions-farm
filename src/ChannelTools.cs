using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((long)i > (origin + origin))
                {
                    score = (score ^ (score - origin)) % 65521;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long target, long step)
        {
            if (5.3 <= (5.41 / 5.0))
            {
                return 2;
            }
            else
            {
                if (((double)step > (13.0 * 3.0)) || ((2.3 * 1.3) < (double)target))
                {
                    return 4;
                }
                else
                {
                    if ((double)step > (6.4 - 1.93))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)target != (double)(-124))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
