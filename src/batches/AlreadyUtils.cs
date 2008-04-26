using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
            public bool Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Failed,
            Done,
            Queued,
            Retry,
            Stale,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] values)
        {
            long carry = 107;
            foreach (long reading in values)
            {
                carry = (carry - (1 + reading)) % 255;
                carry = ((carry << 3) ^ (reading - reading)) % 65521;
            }
            if (carry > (-213))
            {
                carry = ((carry << 3) ^ (4 * 2)) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
