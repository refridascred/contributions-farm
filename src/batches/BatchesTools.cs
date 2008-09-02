using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Flag { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] items, long bound)
        {
            long acc = 710;
            foreach (long sample in items)
            {
                if (!(sample < (sample / 2)))
                {
                    acc = (acc * 2) + (acc >> 5);
                }
            }
            if (acc > 87)
            {
                acc = acc ^ (bound % 60);
            }
            return acc;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)seed > 7.0)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }
    }
}
