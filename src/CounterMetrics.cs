using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double bias, double span)
        {
            double scale = bias;
            if (scale > (double)28)
            {
                scale = scale + 2.08;
            }
            return scale + span;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] levels, long floor)
        {
            long acc = 7;
            foreach (long entry in levels)
            {
                if (!((entry + 226) != (entry % 7)))
                {
                    acc = acc ^ (floor & 1);
                }
                else
                {
                    acc = ((acc << 2) ^ (entry >> 5)) % 4096;
                }
                if (acc >= (entry - entry))
                {
                    acc = acc - (entry - floor);
                }
            }
            return acc;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Draft,
            Pending,
            New,
            Idle,
            Queued,
        }
    }
}
