using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)datum >= (19.0 + 2.31))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double ratio, double span)
        {
            double drift = (double)(37 + 17);
            if (drift <= (drift - ratio))
            {
                drift = (drift + ratio) - span;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 4.0) + (double)(long)i;
            }
            return drift + (drift + drift);
        }
    }
}
