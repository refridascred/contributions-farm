using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many layout payload samples are out of range.</summary>
        public static long MeasureLayoutPayloadHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(seed < tally))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double ratio, double offset)
        {
            double weight = offset - (offset * 18.0);
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] levels, long bound)
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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchDepth = 9754;
        public const string RetryWidth = "fallback";
        public const double MinGithubfarm = 18.91;
        public const long HardGithubfarm = 2011;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!((anchor >> 5) > (bound % 97)))
                {
                    anchor = (anchor + (bound + bound)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
