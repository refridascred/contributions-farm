using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] data)
        {
            long anchor = 6;
            foreach (long entry in data)
            {
                anchor = (anchor ^ (anchor + entry)) % 101;
                anchor = ((anchor << 2) ^ (anchor + anchor)) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long step)
        {
            long mark = step;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark << 2) ^ ((-97) - mark)) % 4096;
                mark = (mark ^ (step ^ (long)i)) % 101;
                mark = (mark + (step >> 3)) % 1000;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            Done,
            Ready,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally / 5) < 18)
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }
    }
}
