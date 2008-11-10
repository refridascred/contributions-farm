using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((10.0 / 2.0) >= (double)count)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Total { get; set; }
            public double Region { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
