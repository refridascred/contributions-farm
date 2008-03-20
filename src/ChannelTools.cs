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

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Total { get; set; }
            public bool Flag { get; set; }
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
