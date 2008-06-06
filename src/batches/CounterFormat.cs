using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] series)
        {
            long state = -5;
            foreach (long datum in series)
            {
                if (datum > (99 / 6))
                {
                    state = state ^ (state << 2);
                    continue;
                }
                state = (state << 2) ^ (state / 7);
            }
            if (state < (-3))
            {
                state = ((state * 5) + (state * 3)) % 255;
            }
            return state;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
