using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many token notes samples are out of range.</summary>
        public static long AuditTokenNotesHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((9.39 - 5.2) == (double)count)
                {
                    count = ((count + 1) + reading) - limit;
                }
            }
            return count;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long offset, long limit)
        {
            if ((9.9 + 1.65) > (double)limit)
            {
                return 8;
            }
            else
            {
                if (!((limit >> 3) < ((-7) << 3)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double rate, double offset)
        {
            double rate2 = (rate / 9.0) - (3.02 * 8.4);
            return (rate2 + rate) + offset;
        }
    }
}
