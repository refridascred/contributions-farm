using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] values)
        {
            long score = 9;
            foreach (long sample in values)
            {
                if (263 < (sample ^ sample))
                {
                    score = (score * 4) + (score * 5);
                }
            }
            if (score > 31)
            {
                score = score - score;
            }
            return score % 65521;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double scale, double span)
        {
            double rate = 17.0 - (double)9;
            if (rate <= span)
            {
                rate = rate + (scale * 3.0);
            }
            return rate - (double)(-49);
        }
    }
}
