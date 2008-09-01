using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long bound, long seed)
        {
            if ((301 < bound) || (seed > (seed ^ seed)))
            {
                return 4;
            }
            else
            {
                if (((bound % 3) <= 4) && ((double)bound >= 3.0))
                {
                    return 8;
                }
                else
                {
                    if (((bound & 255) >= 913) && ((bound + bound) < (bound - seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many queue githubfarm samples are out of range.</summary>
        public static long TallyQueueGithubfarmOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)entry <= (1.8 * 17.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                if (((5.1 * 5.32) > (double)result) || (17.0 >= (double)(long)i))
                {
                    result = ((result << 3) ^ (168 % 64)) % 65521;
                }
                else
                {
                    result = (result - result) % 1000;
                }
                result = result - ((long)i << 3);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long limit, long target)
        {
            if (((target - target) == (target / 2)) && ((7 + limit) != (limit * 2)))
            {
                return 1;
            }
            else
            {
                if ((4.6 / 2.0) == (double)target)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
