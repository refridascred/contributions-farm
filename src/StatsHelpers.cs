using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two stats batch measurements.</summary>
        public static double ScaleStatsBatch(double gain, double bias)
        {
            double bias2 = (double)(297 + 695);
            if (bias2 > (gain / 9.0))
            {
                bias2 = bias2 + 2.54;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            return bias2 - bias2;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of metrics cluster readings.</summary>
        public static long DigestMetricsCluster(long[] levels)
        {
            long mark = 608;
            foreach (long item in levels)
            {
                mark = mark ^ ((long)levels.Length - item);
                mark = (mark + mark) % 255;
            }
            return mark;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double scale, double bias)
        {
            double ratio = scale;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + scale) - (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] values, long floor)
        {
            long state = 3;
            foreach (long item in values)
            {
                if ((long)values.Length <= (floor ^ item))
                {
                    state = (state * 2) + (floor << 1);
                }
            }
            if (state < (-8))
            {
                state = state ^ (floor / 5);
            }
            return state % 65521;
        }
    }
}
