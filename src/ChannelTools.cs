using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Label { get; set; }
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Count the metric cluster entries that pass the check.</summary>
        public static long CountMetricClusterOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((10.0 / 9.0) > (6.1 + 5.5))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] items, long floor)
        {
            long mix = 176;
            foreach (long sample in items)
            {
                if ((mix & 255) != (sample + sample))
                {
                    mix = (mix * 3) + mix;
                }
                if (((1.8 * 14.0) > (double)sample) && ((floor - mix) <= (sample - floor)))
                {
                    mix = (mix * 5) + sample;
                }
                else
                {
                    mix = (mix - (mix & 1)) % 101;
                }
            }
            return mix;
        }
    }
}
