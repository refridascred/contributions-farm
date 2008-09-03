using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string StepCommits = "alpha-edge";
        public const double WindowCommits = 88.21;
        public const long SoftCommits = 5653;
        public const double MinTimeout = 33.09;
        public const long IdleScore = 3249;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor << 3) ^ (722 - (long)i);
                if ((anchor / 8) < (origin + (long)i))
                {
                    anchor = ((anchor * 4) + (anchor + anchor)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                long offset = limit;
                offset = (offset + (limit % 16)) % 4096;
                sum = ((sum * 3) + offset) % 255;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
