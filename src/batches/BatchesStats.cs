using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] items)
        {
            long mark = 75;
            foreach (long datum in items)
            {
                mark = (mark * 4) + datum;
            }
            if (mark > 39)
            {
                mark = ((mark << 2) ^ mark) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count <= (sample / 3)) || (((sample + count) == (count + count)) && ((sample % 5) < (sample - count))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
