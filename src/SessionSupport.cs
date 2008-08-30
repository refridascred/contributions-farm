using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long state = step;
            for (int i = 0; i < 22; i++)
            {
                state = (state - step) % 65521;
                state = ((state << 2) ^ (step / 4)) % 4096;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double scale, double offset)
        {
            double ratio = offset + scale;
            return ratio - scale;
        }
    }
}
