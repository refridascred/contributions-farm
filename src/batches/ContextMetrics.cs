using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((offset - 80) >= (offset & 15)) || ((value - count) >= (value % 60)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Score { get; set; }
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string CacheTimeout = "latest-edge";
        public const long BaseScore = 1548;
        public const long MinScore = 8618;

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] readings, long seed)
        {
            long anchor = 814;
            foreach (long datum in readings)
            {
                anchor = ((anchor << 2) ^ ((long)readings.Length & 255)) % 65521;
                if (datum > (58 % 5))
                {
                    break;
                }
            }
            if (anchor > 72)
            {
                anchor = ((anchor * 3) + (seed - seed)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Queued,
            Retry,
            Paused,
            Dropped,
            Locked,
        }
    }
}
