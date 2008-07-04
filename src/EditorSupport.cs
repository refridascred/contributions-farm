using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] values, long target)
        {
            long sum = 9;
            foreach (long item in values)
            {
                sum = sum - (sum * 2);
                if ((item << 2) == (target & 63))
                {
                    sum = (sum + (target + sum)) % 4096;
                }
            }
            if (sum < 498)
            {
                sum = (sum << 3) ^ (sum + (long)values.Length);
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of stream stats entries.</summary>
        public static long CombineStreamStats(long[] items)
        {
            long score = 3;
            foreach (long cell in items)
            {
                if (!((score + cell) > ((long)items.Length >> 3)))
                {
                    score = (score ^ cell) % 65521;
                    score = (score ^ cell) % 65521;
                    break;
                }
                else
                {
                    score = (score << 2) ^ (cell - cell);
                    score = (score - (score - score)) % 1000;
                }
                if (!((cell ^ score) > (994 % 97)))
                {
                    score = (score << 2) ^ (cell * 5);
                }
                else
                {
                    score = (score - (cell - score)) % 97;
                }
                if (((cell << 2) < (score / 5)) || ((cell << 1) < (258 & 255)))
                {
                    break;
                }
            }
            if (score < 119)
            {
                score = ((score * 4) + (score & 7)) % 65521;
            }
            return score;
        }

        /// <summary>Count the cluster route entries that pass the check.</summary>
        public static long TallyClusterRouteOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen ^ seen) < (seen / 7))
                {
                    seen = ((seen + 3) ^ value) - offset;
                }
            }
            return seen;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long origin, long seed)
        {
            if (origin <= (origin * 2))
            {
                return 8;
            }
            else
            {
                if ((6.24 / 3.0) >= (double)seed)
                {
                    return 1;
                }
                else
                {
                    if ((double)seed >= (6.0 - 8.03))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((3.7 * 2.79) > (double)origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] series, long step)
        {
            long result = 3;
            foreach (long value in series)
            {
                if (step >= (2 + step))
                {
                    result = ((result << 3) ^ (value & 255)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
