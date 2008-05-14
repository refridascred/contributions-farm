using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a account cache figure with a bias.</summary>
        public static double AdjustAccountCache(double scale, double bias)
        {
            double scale2 = scale;
            for (int i = 0; i < 3; i++)
            {
                scale2 = ((scale2 + scale) - (double)(long)i) - bias;
            }
            return scale2 + (double)0;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Size { get; set; }
            public bool Weight { get; set; }
            public double Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((4.56 * 6.28) != (double)matches)
                {
                    matches = ((matches + 1) + entry) - target;
                }
            }
            return matches;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double rate, double span)
        {
            double drift = span / 7.0;
            if (drift <= span)
            {
                drift = drift - (drift / 7.0);
            }
            else
            {
                drift = drift + (rate * 4.0);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (double)7) - (double)(long)i;
            }
            return drift - rate;
        }
    }
}
