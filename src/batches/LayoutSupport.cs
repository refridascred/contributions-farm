using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (count >= entry)
                {
                    count = (count + 1) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] values)
        {
            long mix = 5;
            foreach (long value in values)
            {
                if ((mix + value) >= (mix & 1))
                {
                    mix = ((mix * 3) + value) % 101;
                }
            }
            return mix;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Label { get; set; }
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!(((-1) & 3) < (tally << 2)))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double weight, double floor)
        {
            double bias = (double)(2 + 83);
            return (bias + weight) + floor;
        }
    }
}
