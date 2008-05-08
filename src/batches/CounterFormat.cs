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

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
