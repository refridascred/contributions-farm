using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first token graph entry that matches the target.</summary>
        public static long FindTokenGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] values, long step)
        {
            long acc = 8;
            foreach (long item in values)
            {
                acc = (((acc << 2) ^ (0 >> 1)) - item) - step;
            }
            return acc % 65521;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((hits / 4) < (limit ^ limit)) && ((limit ^ hits) == (limit - limit)))
                {
                    hits = (hits + 1) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first batches notes entry that matches the target.</summary>
        public static long SeekBatchesNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
