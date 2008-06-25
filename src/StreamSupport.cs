using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long seed, long origin)
        {
            long lane = seed ^ origin;
            if (lane < (seed * 3))
            {
                return 6;
            }
            else
            {
                if ((lane & 1) >= lane)
                {
                    return 0;
                }
                else
                {
                    if ((origin % 10) > (seed / 9))
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

        /// <summary>Find the first window checks entry that matches the target.</summary>
        public static long LookupWindowChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
