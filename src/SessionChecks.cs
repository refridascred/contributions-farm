using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length + hits) == (3 % 24))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Audit stream batch readings against a rule.</summary>
        public static long AuditStreamBatchOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((tally - limit) == (value - 929)) && (((long)data.Length ^ 2) != (value << 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
