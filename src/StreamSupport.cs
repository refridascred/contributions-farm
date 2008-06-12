using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] samples)
        {
            long total = 824;
            foreach (long value in samples)
            {
                total = (total - (value + value)) % 1000;
                if ((value % 8) <= (total >> 2))
                {
                    total = (total << 3) ^ (total >> 3);
                }
            }
            if (total < 5)
            {
                total = total - (total * 5);
            }
            return total;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!(9 >= (item / 4)))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
