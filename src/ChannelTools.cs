using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] series, long origin)
        {
            long carry = 584;
            foreach (long value in series)
            {
                carry = ((carry * 5) + (origin & 7)) + value;
            }
            return carry;
        }
    }
}
