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

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)tally > (3.5 - 2.0))
                {
                    tally = (tally + 1) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
