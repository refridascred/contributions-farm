using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Draft,
            Idle,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Offset { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
        }
    }
}
