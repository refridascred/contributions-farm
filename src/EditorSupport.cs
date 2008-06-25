using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits << 2) > (entry + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryDepth = 88.61;
        public const long RetryWindow = 9027;
        public const long IdleWidth = 4470;
        public const long DefaultDepth = 124;

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Flag { get; set; }
            public bool Rank { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer channel readings against a rule.</summary>
        public static long TallyBufferChannelMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((double)datum == (double)tally) || (((datum + datum) < (tally ^ tally)) && ((double)datum > (3.0 * 6.8))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Synced,
            Idle,
            Done,
            Retry,
            Paused,
        }
    }
}
