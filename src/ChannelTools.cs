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

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
