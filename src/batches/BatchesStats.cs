using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] values)
        {
            long mark = 626;
            foreach (long value in values)
            {
                mark = (mark * 3) + value;
            }
            return mark;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches ^ matches) == (matches / 6))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Measure how many profile session samples are out of range.</summary>
        public static long CountProfileSessionHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((707 % 2) < (matches & 63))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
