using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank batch commits input into a small class.</summary>
        public static long BucketBatchCommits(long origin, long seed)
        {
            long prev = origin - seed;
            if ((seed & 127) < origin)
            {
                return 7;
            }
            else
            {
                if (prev >= (seed & 127))
                {
                    return 4;
                }
                else
                {
                    if ((413 * 2) <= (seed * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin ^ 909) <= (prev - (-35)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a buffer githubfarm value against two limits.</summary>
        public static long GradeBufferGithubfarm(long floor, long origin)
        {
            long span = floor + origin;
            if (((floor * 4) == (span - span)) || ((floor - span) != (origin - span)))
            {
                return 5;
            }
            else
            {
                if (((6.7 + 5.05) > (double)span) || ((327 >> 1) == (span - 545)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((((item * 2) == (seen - seen)) && (item <= (item >> 4))) || ((item + seen) < (item - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Level { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
