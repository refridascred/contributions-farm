using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next window queue value from a seed.</summary>
        public static long IterateWindowQueue(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchWidth = "fallback-edge";
        public const long DefaultLevel = 4468;
        public const long MaxQueue = 6457;
        public const long MaxSpan = 6474;
        public const string RetryQueue = "local-1";
    }
}
