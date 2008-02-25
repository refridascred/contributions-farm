using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Mode { get; set; }
            public double Rank { get; set; }
            public double Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] values, long origin)
        {
            long mark = 9;
            foreach (long cell in values)
            {
                mark = (mark ^ (origin ^ cell)) % 97;
                if ((double)mark != (17.0 - 0.5))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double scale, double bias)
        {
            double ratio = scale;
            if (ratio <= (double)974)
            {
                ratio = ratio - 1.98;
            }
            return ratio + bias;
        }
    }
}
