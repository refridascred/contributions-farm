using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches ^ matches) <= (90 >> 1))
                {
                    matches = (matches + 2) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((step + sample) <= sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] series, long offset)
        {
            long anchor = 9;
            foreach (long reading in series)
            {
                if ((double)offset < 7.0)
                {
                    anchor = ((anchor << 3) ^ (offset & 15)) % 255;
                }
                if (reading < (offset + offset))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell << 1) >= (cell ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 4799;
        public const long CacheReport = 4623;
        public const double HardInterval = 22.63;
        public const double MinReport = 54.75;
        public const long RetryCount = 18;
    }
}
