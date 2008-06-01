using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Stamp { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Mode { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double gain, double floor)
        {
            double drift = (1.91 - floor) + (double)788;
            if (drift >= (gain / 4.0))
            {
                drift = drift + (7.2 + drift);
            }
            else
            {
                drift = drift - (gain + gain);
            }
            return drift + (7.2 / 6.0);
        }
    }
}
