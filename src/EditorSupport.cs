using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string MinGraph = "cached-edge";
        public const string BaseBudget = "strict";
        public const long DefaultGraph = 1656;
        public const long WindowInterval = 2736;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((-507) > target)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (hits >= sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Locked,
            Paused,
            Pending,
            Synced,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((4 + hits) > (hits << 1))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
