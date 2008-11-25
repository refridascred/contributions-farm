using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Pending,
            Synced,
            Queued,
            Failed,
            Draft,
        }
    }
}
