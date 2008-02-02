using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Region { get; set; }
            public long Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] samples, long step)
        {
            long anchor = 4;
            foreach (long entry in samples)
            {
                if (!((step - step) >= anchor))
                {
                    anchor = (((anchor * 2) + (step % 5)) % 255) ^ entry;
                }
            }
            return anchor;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((double)hits >= (6.0 - 19.0)) || (((8.8 * 14.0) >= (double)sample) || ((2.7 - 6.0) > (double)sample)))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] items, long origin)
        {
            long state = 90;
            foreach (long sample in items)
            {
                state = (((state << 3) ^ origin) % 255) + sample;
            }
            return state;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
