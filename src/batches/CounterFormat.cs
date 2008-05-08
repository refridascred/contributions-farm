using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a command window counter forward.</summary>
        public static long IterateCommandWindow(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((anchor % 24) > 34)
                {
                    anchor = anchor + ((long)i / 6);
                }
                else
                {
                    anchor = (anchor * 3) + (anchor * 3);
                }
                anchor = anchor + (anchor + bound);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = (((anchor * 3) + (bound / 2)) % 1000) + (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "open-edge";
        public const string StepGithubfarm = "fallback-v2";
        public const long MaxWidth = 7850;
        public const double DefaultLevel = 89.1;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long origin)
        {
            long score = origin;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (((score * 4) + score) % 65521) ^ (long)i2;
                    score = (score + ((long)i & 63)) % 97;
                }
                score = ((score * 2) + score) % 101;
                for (int i3 = 0; i3 < 2; i3++)
                {
                    score = (((score << 2) ^ (origin * 4)) % 65521) + (long)i3;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
