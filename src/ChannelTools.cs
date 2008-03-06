using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 <= (offset * 8.19))
            {
                weight2 = weight2 - (weight2 - offset);
            }
            else
            {
                weight2 = weight2 + weight2;
            }
            return weight2 + (2.3 - offset);
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
