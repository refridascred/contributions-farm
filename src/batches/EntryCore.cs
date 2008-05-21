using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double weight, double span)
        {
            double rate = (span / 3.0) - weight;
            if (rate > 7.53)
            {
                rate = rate - (double)(-81);
            }
            return rate + rate;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long seed, long offset)
        {
            long gap = seed - offset;
            if ((double)gap >= (double)offset)
            {
                return 5;
            }
            else
            {
                if (seed < (offset * 3))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Pending,
            Locked,
            New,
            Paused,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            Ready,
            Stale,
            Pending,
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
            public double Label { get; set; }
            public bool Flag { get; set; }
        }
    }
}
