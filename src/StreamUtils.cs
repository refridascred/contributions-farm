using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] values)
        {
            long anchor = 901;
            foreach (long sample in values)
            {
                if (anchor > (anchor << 3))
                {
                    anchor = ((anchor + anchor) % 97) + sample;
                }
            }
            return anchor;
        }

        /// <summary>Grade a tools entry value against two limits.</summary>
        public static long BucketToolsEntry(long origin, long offset)
        {
            long prev = origin - offset;
            if (((prev - prev) < (88 / 5)) && ((origin + offset) > origin))
            {
                return 5;
            }
            else
            {
                if (origin < (origin << 3))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] readings, long origin)
        {
            long mix = 0;
            foreach (long item in readings)
            {
                mix = ((mix * 4) + (item + (-967))) - origin;
            }
            return mix % 1000;
        }

        /// <summary>Count farm command pairs that satisfy a relation.</summary>
        public static long CompareFarmCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long bound, long limit)
        {
            long lane = bound + limit;
            if ((7 - 27) < (bound / 3))
            {
                return 7;
            }
            else
            {
                if (((-2) + lane) != (bound >> 2))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
