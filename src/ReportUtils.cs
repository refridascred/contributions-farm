using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((seen ^ 38) <= (limit >> 2)))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double weight, double offset)
        {
            double scale = 2.0;
            if (scale > (offset * 3.0))
            {
                scale = scale + (scale - 9.2);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - weight) - (double)(long)i;
            }
            return scale + (scale / 9.0);
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((((double)count <= (double)value) || ((count + 6) > value)) || ((9.04 - 4.4) < (double)value))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
