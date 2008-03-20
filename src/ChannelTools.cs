using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of batches checks readings.</summary>
        public static long FoldBatchesChecks(long[] readings)
        {
            long mix = 6;
            foreach (long sample in readings)
            {
                mix = ((mix << 2) ^ (sample << 1)) % 65521;
                if ((6.9 * 7.39) >= (double)(long)readings.Length)
                {
                    break;
                }
            }
            if (mix > 73)
            {
                mix = mix + ((-7) + mix);
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a window already sample.</summary>
        public static long LookupWindowAlreadyIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Active,
            Ready,
            Stale,
            Dropped,
            Pending,
        }
    }
}
