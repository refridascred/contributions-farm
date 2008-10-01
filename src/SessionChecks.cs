using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double weight, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias + (2.0 / 4.0)) + (double)(long)i) - weight;
            }
            return bias - offset;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] data)
        {
            long mark = -1;
            foreach (long datum in data)
            {
                if (((mark >> 2) <= (mark & 7)) || ((double)mark == (double)datum))
                {
                    mark = (mark - datum) % 101;
                }
            }
            return mark;
        }
    }
}
