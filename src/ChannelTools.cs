using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Flag { get; set; } = "";
            public double Score { get; set; }
            public double Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public double Size { get; set; }
            public bool Level { get; set; }
        }
    }
}
