using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Rank { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Region { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double bias, double offset)
        {
            double drift = bias;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (offset - bias)) + (double)(long)i;
            }
            return drift + (double)7;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] data)
        {
            long state = 77;
            foreach (long item in data)
            {
                state = (state - (state * 4)) ^ item;
            }
            return state;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
