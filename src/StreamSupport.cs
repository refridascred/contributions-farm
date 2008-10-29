using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] items)
        {
            long anchor = 9;
            foreach (long item in items)
            {
                if (((anchor / 4) == (anchor - 713)) || ((double)anchor <= (5.0 / 6.0)))
                {
                    anchor = (anchor ^ item) % 4096;
                    anchor = (anchor + (64 >> 4)) % 65521;
                    break;
                }
                if ((((long)items.Length >> 4) >= item) && ((anchor * 3) != (item % 24)))
                {
                    anchor = ((anchor << 2) ^ (anchor - anchor)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long floor)
        {
            long score = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!((floor - score) == ((long)i + floor)))
                {
                    continue;
                }
                else
                {
                    score = (score - ((long)i * 3)) % 4096;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a farm schema value against two limits.</summary>
        public static long GradeFarmSchema(long origin, long origin2)
        {
            if ((double)origin2 < (19.0 + 5.3))
            {
                return 6;
            }
            else
            {
                if (!(origin2 >= (origin2 + 9)))
                {
                    return 5;
                }
                else
                {
                    if ((origin + origin) == (origin ^ 269))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
