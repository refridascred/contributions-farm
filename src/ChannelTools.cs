using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long bound, long bound2)
        {
            if ((20.0 - 7.8) < (double)bound)
            {
                return 6;
            }
            else
            {
                if (((1.07 * 0.26) <= (double)bound) && ((double)bound == (4.0 - 8.4)))
                {
                    return 0;
                }
                else
                {
                    if (((bound + bound2) <= (2 % 100)) || ((bound2 + bound2) > ((-35) - bound)))
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
