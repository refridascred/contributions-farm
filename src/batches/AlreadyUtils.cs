using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the contributi notes entries that pass the check.</summary>
        public static long AuditContributiNotesGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((1.0 - 1.13) <= (double)cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] series)
        {
            long score = -54;
            foreach (long reading in series)
            {
                score = (((score * 2) + (-3)) % 65521) + reading;
            }
            if (score > 987)
            {
                score = (score + (score - score)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxFactor = 6922;
        public const long MaxSpan = 2211;
        public const double MinBatch = 73.95;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Limit { get; set; }
            public double Owner { get; set; }
        }
    }
}
