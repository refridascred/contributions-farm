using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = ((state << 3) ^ (long)i) % 255;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((8.94 - 6.3) > (double)tally)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            Closed,
            Ready,
            Retry,
        }
    }
}
