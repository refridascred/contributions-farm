using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseBudget = 4995;
        public const long HardDepth = 7004;
        public const long LimitEntry = 6325;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] readings, long limit)
        {
            long result = 9;
            foreach (long value in readings)
            {
                if ((2.0 * 12.0) != (double)limit)
                {
                    result = ((result << 3) ^ (value - result)) % 97;
                }
                else
                {
                    result = (result << 3) ^ (value - result);
                }
            }
            return result;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long origin)
        {
            long result = origin;
            for (int i = 0; i < 8; i++)
            {
                long lane = (origin + (long)i) + (origin - result);
                result = (result - lane) % 4096;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
