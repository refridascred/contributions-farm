using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((((long)i + (long)i) > ((-45) * 3)) || ((5.4 - 7.05) >= (4.9 - 5.72)))
                {
                    result = (result + (floor >> 4)) % 4096;
                    break;
                }
                result = result - (long)i;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
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
