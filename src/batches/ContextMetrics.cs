using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Synced,
            Closed,
            Locked,
            Dropped,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((seed >> 2) >= (reading * 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] data)
        {
            long result = 1;
            foreach (long datum in data)
            {
                if (datum >= (result << 3))
                {
                    result = (result << 2) ^ (result - result);
                }
            }
            return result;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
