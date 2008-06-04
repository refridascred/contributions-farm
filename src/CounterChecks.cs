using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Closed,
            Done,
            Stale,
            Active,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultSize = 81.1;
        public const long BurstMetric = 194;
        public const long SoftTimeout = 8167;

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] readings)
        {
            long anchor = 692;
            foreach (long datum in readings)
            {
                anchor = (anchor ^ (datum & 31)) % 101;
            }
            return anchor;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally - tally) < (9 + tally))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Level { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }
    }
}
