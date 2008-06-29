using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Idle,
            Active,
            Done,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] data)
        {
            long total = 60;
            foreach (long datum in data)
            {
                if ((total & 3) <= (datum - total))
                {
                    total = (total << 3) ^ (0 + datum);
                }
            }
            return total;
        }

        /// <summary>Count the counter stats entries that pass the check.</summary>
        public static long TallyCounterStatsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((717 << 3) > (matches << 1))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
