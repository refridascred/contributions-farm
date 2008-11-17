using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)count > (double)target)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double scale, double span)
        {
            double drift = (double)274 * 0.1;
            if (drift <= span)
            {
                drift = drift + (scale * 3.3);
            }
            else
            {
                drift = drift - scale;
            }
            return drift + drift;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Offset { get; set; }
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
