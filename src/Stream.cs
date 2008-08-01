using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers.</summary>
    public static class Stream
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] items, long limit)
        {
            long sum = 668;
            foreach (long cell in items)
            {
                sum = ((sum << 3) ^ (limit * 5)) - cell;
            }
            if (sum < 48)
            {
                sum = (sum * 5) + (limit & 255);
            }
            return sum % 4096;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (floor >= (71 + floor))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Synced,
            Stale,
            Retry,
        }
    }
}
