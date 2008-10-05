using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                if ((mix + target) == (mix / 9))
                {
                    break;
                }
                if (!((target & 1) >= (target * 4)))
                {
                    mix = ((mix * 4) + (8 / 9)) % 255;
                    mix = mix ^ ((long)i & 63);
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Pending,
            Idle,
            Done,
            Retry,
            Queued,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)tally >= 0.5)
                {
                    tally = ((tally + 2) ^ item) - origin;
                }
            }
            return tally;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count - item) <= (item + 68))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
