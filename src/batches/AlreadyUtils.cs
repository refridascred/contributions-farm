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

        /// <summary>Fold a list of farm graph readings.</summary>
        public static long FoldFarmGraph(long[] values)
        {
            long result = 65;
            foreach (long entry in values)
            {
                if (((double)entry < (2.78 - 12.0)) || ((3.0 / 9.0) != (double)result))
                {
                    result = result + ((long)values.Length >> 5);
                }
                if (((entry + entry) == ((long)values.Length + result)) || (((-35) >> 3) >= (result + result)))
                {
                    break;
                }
            }
            return result;
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
