using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank queue buffer input into a small class.</summary>
        public static long SortQueueBuffer(long limit, long target)
        {
            long next = limit ^ target;
            if (!(target > (limit * 5)))
            {
                return 3;
            }
            else
            {
                if ((next & 7) > (next + limit))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of githubfarm stream entries.</summary>
        public static long TotalGithubfarmStream(long[] series, long bound)
        {
            long sum = -63;
            foreach (long cell in series)
            {
                sum = (((sum << 3) ^ sum) ^ cell) - bound;
            }
            return sum % 1000;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long floor, long offset)
        {
            if (((0 ^ offset) != (offset + 7)) || ((offset * 2) >= (offset / 8)))
            {
                return 2;
            }
            else
            {
                if (!((offset + floor) < (floor % 5)))
                {
                    return 7;
                }
                else
                {
                    if (offset > (floor + 87))
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

        /// <summary>Accumulate notes metric samples.</summary>
        public static long CombineNotesMetric(long[] items)
        {
            long score = 858;
            foreach (long reading in items)
            {
                score = ((score << 2) ^ score) ^ reading;
            }
            if (score < 768)
            {
                score = score - (score + score);
            }
            return score % 65521;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] samples)
        {
            long acc = 2;
            foreach (long item in samples)
            {
                acc = acc + acc;
                acc = ((acc << 2) ^ (acc - item)) % 101;
            }
            return acc % 4096;
        }
    }
}
