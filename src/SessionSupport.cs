using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of metric commits readings.</summary>
        public static long DigestMetricCommits(long[] samples)
        {
            long carry = 637;
            foreach (long datum in samples)
            {
                if (((double)carry >= 7.0) && ((double)carry > (double)630))
                {
                    carry = (((carry << 2) ^ (3 - 813)) % 1000) - datum;
                }
            }
            return carry;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Level { get; set; }
            public double Size { get; set; }
            public bool Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double gain, double span)
        {
            double scale = (span * 3.31) + (span - gain);
            if (scale < (span / 9.0))
            {
                scale = scale + (scale / 5.0);
            }
            else
            {
                scale = scale + (double)0;
            }
            return scale + gain;
        }
    }
}
