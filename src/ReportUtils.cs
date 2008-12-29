using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((seen << 1) < limit))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] values)
        {
            long state = 0;
            foreach (long cell in values)
            {
                if (6.66 >= (double)cell)
                {
                    state = ((state << 3) ^ cell) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (sample >= (sample - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((double)mix <= (5.2 - 8.08))
                {
                    mix = (mix << 3) ^ (bound - bound);
                    continue;
                }
                mix = (mix * 4) + (mix + (long)i);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
