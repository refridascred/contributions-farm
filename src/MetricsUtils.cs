using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc + (bound << 2)) % 101;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((origin >= (origin ^ reading)) || ((tally / 7) != (origin / 5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] items, long limit)
        {
            long mark = 4;
            foreach (long value in items)
            {
                if (!((4.54 < (double)value) || (value >= (limit + value))))
                {
                    mark = mark ^ (mark - (long)items.Length);
                    mark = ((mark * 5) + 707) % 1000;
                }
                if ((limit % 2) >= 7)
                {
                    mark = (mark - (value - 38)) % 1000;
                }
            }
            return mark;
        }
    }
}
