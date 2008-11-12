using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Level { get; set; }
            public bool Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Ready,
            Paused,
            Queued,
            Closed,
            Synced,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long offset, long target)
        {
            long offset2 = offset + target;
            if (((offset2 & 31) > target) || ((offset2 % 12) < 299))
            {
                return 0;
            }
            else
            {
                if ((272 - offset) != (offset2 - target))
                {
                    return 7;
                }
                else
                {
                    if (target < (offset + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
