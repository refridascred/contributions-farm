using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Size { get; set; }
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 2366;
        public const long BatchCount = 6001;
        public const long MinScore = 684;
        public const long BurstTimeout = 2408;

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double bias, double span)
        {
            double gain = (bias * 3.17) * 7.5;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + span) + (double)(long)i;
            }
            return gain + (double)5;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long bound, long limit)
        {
            if (((bound & 1) != (limit - bound)) || ((14.0 / 4.0) < (double)bound))
            {
                return 1;
            }
            else
            {
                if ((limit / 5) != (bound ^ 17))
                {
                    return 4;
                }
                else
                {
                    if ((9 ^ limit) > (limit * 2))
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

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
