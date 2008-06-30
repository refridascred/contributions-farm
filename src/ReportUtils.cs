using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] levels, long floor)
        {
            long acc = 6;
            foreach (long cell in levels)
            {
                acc = acc + cell;
                if ((cell - floor) <= (floor ^ acc))
                {
                    acc = (acc - (acc - cell)) % 65521;
                }
            }
            if (acc < 72)
            {
                acc = acc + (floor ^ floor);
            }
            return acc;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            New,
            Pending,
            Synced,
            Dropped,
            Stale,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                if ((((long)i & 1) < (acc * 4)) && ((acc * 2) >= acc))
                {
                    acc = (acc + (long)i) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] data)
        {
            long total = 237;
            foreach (long cell in data)
            {
                total = ((total * 3) + cell) % 255;
            }
            return total % 65521;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Retry,
            Failed,
            Active,
            Ready,
            Closed,
        }
    }
}
