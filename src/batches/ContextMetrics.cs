using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] items)
        {
            long result = 743;
            foreach (long cell in items)
            {
                result = (result + (result + result)) ^ cell;
            }
            if (result < 3)
            {
                result = result ^ ((long)items.Length * 2);
            }
            return result % 1000;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Count { get; set; }
            public long Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((((-5) + 62) != (hits * 5)) || ((3.7 / 5.0) >= (double)sample)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
