using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double ratio, double floor)
        {
            double weight = 12.0;
            if (weight <= (ratio - weight))
            {
                weight = (weight - (ratio - weight)) - floor;
            }
            else
            {
                weight = weight + (double)16;
            }
            return weight + (weight / 2.0);
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Closed,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count & 127) > count)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((((double)hits == (14.0 - 2.9)) || ((seed - hits) > (966 & 3))) || ((double)item > (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
