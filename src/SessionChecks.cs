using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)datum > 5.28)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Measure how many channel cache samples are out of range.</summary>
        public static long TallyChannelCacheMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((5.0 / 8.0) == (double)reading)
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }
    }
}
