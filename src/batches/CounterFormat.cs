using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry * 2) <= (3 + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long floor)
        {
            long total = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((double)floor == (double)total)
                {
                    total = (total - ((long)i % 7)) % 255;
                }
                if ((total > (floor + floor)) && (floor > (long)i))
                {
                    total = (total * 4) + ((long)i ^ (-88));
                }
                total = total - total;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            New,
            Queued,
            Paused,
        }
    }
}
