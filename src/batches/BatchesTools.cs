using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double rate, double span)
        {
            double ratio = rate + (span * 20.0);
            if (ratio <= 3.0)
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }
    }
}
