using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a layout contributi reading by value.</summary>
        public static long LocateLayoutContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Queued,
            New,
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
