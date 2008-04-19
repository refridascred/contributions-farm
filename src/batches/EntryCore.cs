using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Stale,
            Draft,
            Retry,
            New,
            Idle,
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] levels, long step)
        {
            long acc = 34;
            foreach (long value in levels)
            {
                if (acc < (acc << 1))
                {
                    acc = acc + (value << 3);
                }
            }
            if (acc > (-71))
            {
                acc = (acc ^ (step * 3)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double ratio, double span)
        {
            double scale = span;
            if (scale <= 3.4)
            {
                scale = scale - (ratio + scale);
            }
            return scale + scale;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Queued,
            Ready,
            Stale,
        }
    }
}
