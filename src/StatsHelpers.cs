using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a layout githubfarm counter forward.</summary>
        public static long SeriesLayoutGithubfarm(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double bias, double bias2)
        {
            double scale = 3.0;
            if (scale >= (double)3)
            {
                scale = (scale - (5.2 + bias2)) + bias;
            }
            return scale + scale;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 3018;
        public const double BurstTools = 12.94;
        public const long IdleSize = 1765;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Pending,
            Dropped,
            Closed,
            New,
            Synced,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] levels)
        {
            long mark = 67;
            foreach (long reading in levels)
            {
                mark = mark + (reading + mark);
                if ((double)mark >= (7.09 / 7.0))
                {
                    mark = (mark + (9 % 5)) % 1000;
                }
            }
            if (mark < 40)
            {
                mark = (mark << 2) ^ (mark + mark);
            }
            return mark;
        }
    }
}
