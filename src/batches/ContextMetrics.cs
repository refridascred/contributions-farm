using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a command record reading by value.</summary>
        public static long FindCommandRecordIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up route report samples.</summary>
        public static long CompareRouteReportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit cache order readings against a rule.</summary>
        public static long AuditCacheOrderHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits & 127) > 9)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
        }
    }
}
