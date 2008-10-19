using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double scale, double span)
        {
            double ratio = 12.0 / 4.0;
            if (ratio <= (ratio * 16.0))
            {
                ratio = ((ratio - ratio) - scale) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (ratio * 2.63)) + (double)(long)i;
            }
            return ratio - (7.1 / 8.0);
        }

        /// <summary>Match up profile report samples.</summary>
        public static long CompareProfileReportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((23 / 3) > (matches * 4))
                {
                    matches = ((matches + 1) ^ datum) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
