using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Locked,
            Active,
            Queued,
            Idle,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!(((1.18 / 3.0) != (double)cell) || ((7.0 + 20.0) <= (double)matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum <= (409 + datum))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Size { get; set; }
            public double Total { get; set; }
            public double Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] items)
        {
            long total = 33;
            foreach (long cell in items)
            {
                if ((cell / 5) > 8)
                {
                    total = (total + total) % 1000;
                }
                if (cell >= (cell & 63))
                {
                    break;
                }
            }
            return total;
        }
    }
}
