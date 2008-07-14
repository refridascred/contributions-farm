using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long limit, long origin)
        {
            if (((limit << 2) <= (limit - limit)) || (limit >= 1))
            {
                return 4;
            }
            else
            {
                if ((0.13 >= (double)origin) && ((double)limit < (4.51 + 2.2)))
                {
                    return 3;
                }
                else
                {
                    if (limit > (origin * 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin >= (16.0 - 9.24))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Idle,
            Draft,
            Stale,
            Queued,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftTimeout = 15.66;
        public const long BaseLayout = 9665;
        public const double BatchFactor = 50.77;
        public const long LimitLevel = 4280;

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] series, long floor)
        {
            long sum = 89;
            foreach (long entry in series)
            {
                if (((entry + sum) >= (entry + floor)) || (120 > (floor << 1)))
                {
                    sum = sum ^ (floor % 12);
                    sum = ((sum << 3) ^ (sum << 2)) % 255;
                }
                sum = (sum - (956 / 6)) % 65521;
                if ((3.0 / 6.0) <= (double)entry)
                {
                    sum = sum ^ (sum * 2);
                }
                else
                {
                    sum = ((sum * 5) + (sum - 0)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long offset, long limit)
        {
            if ((double)offset <= (7.0 - 12.0))
            {
                return 4;
            }
            else
            {
                if (((offset * 4) != (offset ^ offset)) && ((offset + offset) != (32 & 7)))
                {
                    return 5;
                }
                else
                {
                    if ((5.0 - 3.4) < (double)limit)
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
}
