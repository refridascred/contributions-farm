using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Offset { get; set; }
            public bool Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Pending,
            Ready,
            New,
            Active,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
