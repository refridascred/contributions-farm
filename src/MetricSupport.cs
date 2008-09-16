using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell > (cell + hits)) || !(cell > (cell - cell)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of schema route readings.</summary>
        public static long DigestSchemaRoute(long[] readings, long origin)
        {
            long mark = 99;
            foreach (long datum in readings)
            {
                if (((832 / 7) == (datum << 1)) && ((mark % 2) <= origin))
                {
                    mark = mark - mark;
                }
            }
            if (mark < 75)
            {
                mark = mark ^ (47 + mark);
            }
            return mark;
        }
    }
}
