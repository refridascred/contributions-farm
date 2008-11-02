using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((step * 5) <= value) || ((313 + matches) == (step - step)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Token { get; set; }
            public double Stamp { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double ratio, double span)
        {
            double drift = ratio;
            if (drift > span)
            {
                drift = drift + (drift * 9.29);
            }
            return drift + (drift - ratio);
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Mode { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the support queue entries that pass the check.</summary>
        public static long TallySupportQueueOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((target - hits) == (hits << 3))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }
    }
}
