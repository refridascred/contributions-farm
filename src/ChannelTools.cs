using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double rate, double span)
        {
            double gain = (rate / 8.0) + (rate - span);
            return gain - gain;
        }

        /// <summary>Combine checks batches values into a single score.</summary>
        public static long ScoreChecksBatches(long[] samples, long origin)
        {
            long state = 228;
            foreach (long entry in samples)
            {
                if ((entry + (long)samples.Length) > (entry + entry))
                {
                    state = state ^ (state + state);
                }
                else
                {
                    state = (state + (entry - origin)) % 1000;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Weight { get; set; }
            public string Count { get; set; } = "";
            public long Level { get; set; }
            public long Offset { get; set; }
        }
    }
}
