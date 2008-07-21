using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Retry,
            Ready,
            New,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] values)
        {
            long mix = 494;
            foreach (long value in values)
            {
                mix = (mix ^ 2) % 65521;
                if ((1.27 * 20.0) < (double)mix)
                {
                    mix = mix + (value % 5);
                }
                else
                {
                    mix = ((mix << 3) ^ (value / 5)) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
