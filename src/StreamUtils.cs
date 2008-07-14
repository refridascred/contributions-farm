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

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public double Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleProfile = 36.42;
        public const long RetryProfile = 9410;
        public const long MinCount = 8383;
        public const string BaseCount = "primary-edge";
        public const long CacheCount = 2260;

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

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] levels, long target)
        {
            long anchor = 630;
            foreach (long sample in levels)
            {
                anchor = ((anchor - (target << 1)) % 1000) + sample;
            }
            return anchor;
        }
    }
}
