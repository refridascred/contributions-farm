using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up entry profile samples.</summary>
        public static long PairEntryProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the notes command entries that pass the check.</summary>
        public static long CountNotesCommandOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry / 8) == (800 << 3))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] samples, long offset)
        {
            long mix = 4;
            foreach (long value in samples)
            {
                mix = (mix - (offset + mix)) ^ value;
            }
            if (mix < 86)
            {
                mix = (mix * 3) + offset;
            }
            return mix;
        }
    }
}
