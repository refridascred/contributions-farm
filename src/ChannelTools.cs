using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((3.0 + 4.3) > (double)mark))
                {
                    mark = mark - (long)i;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Total { get; set; } = "";
            public double Region { get; set; }
            public long Weight { get; set; }
        }
    }
}
