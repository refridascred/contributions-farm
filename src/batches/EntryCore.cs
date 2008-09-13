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

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Size { get; set; }
            public bool Label { get; set; }
            public long Rank { get; set; }
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

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Weight { get; set; }
            public long Mode { get; set; }
            public double Limit { get; set; }
        }
    }
}
