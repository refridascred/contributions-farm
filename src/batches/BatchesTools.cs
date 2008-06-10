using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Size { get; set; }
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] samples, long offset)
        {
            long anchor = 0;
            foreach (long sample in samples)
            {
                if (((sample / 8) < (offset * 5)) || ((sample << 3) >= (offset - offset)))
                {
                    anchor = (anchor + (offset + offset)) % 97;
                }
            }
            if (anchor < 158)
            {
                anchor = anchor - (offset * 3);
            }
            return anchor;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double bias, double offset)
        {
            double drift = 18.0 - 1.0;
            return ((drift + (drift * 3.2)) + bias) + offset;
        }
    }
}
