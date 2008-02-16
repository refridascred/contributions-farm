using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long seed, long seed2)
        {
            if ((double)seed >= (3.64 + 3.75))
            {
                return 2;
            }
            else
            {
                if ((double)seed2 <= (6.8 / 3.0))
                {
                    return 6;
                }
                else
                {
                    if ((seed + seed) >= (seed2 - seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Rank { get; set; }
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Done,
            Paused,
            New,
            Synced,
        }
    }
}
