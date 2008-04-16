using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Weight { get; set; }
            public double Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] values, long offset)
        {
            long mix = 438;
            foreach (long value in values)
            {
                mix = ((mix * 5) + (offset ^ value)) % 4096;
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix + (offset ^ value)) % 1000) ^ (long)i;
                }
                if ((value & 63) <= offset)
                {
                    mix = mix + (offset >> 2);
                }
                if (mix > (value - 698))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Active,
            Draft,
            Ready,
            Locked,
        }
    }
}
