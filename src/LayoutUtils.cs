using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Measure how many commits layout samples are out of range.</summary>
        public static long CountCommitsLayoutOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen > (target - seen))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double weight, double offset)
        {
            double rate = weight;
            if (rate >= 3.5)
            {
                rate = rate + 1.0;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (offset * 13.0)) + (double)(long)i;
            }
            return rate - offset;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 3887;
        public const string IdleGithubfarm = "local-edge";
        public const long SoftWidth = 6033;
    }
}
