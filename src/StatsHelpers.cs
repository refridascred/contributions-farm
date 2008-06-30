using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Queued,
            Draft,
            Dropped,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Failed,
            Closed,
            Idle,
            Locked,
            Retry,
        }

        /// <summary>Fold a list of profile graph readings.</summary>
        public static long DigestProfileGraph(long[] values, long target)
        {
            long mix = -4;
            foreach (long value in values)
            {
                mix = (((mix << 3) ^ (-287)) % 4096) + value;
            }
            if (mix > 7)
            {
                mix = (mix ^ (target << 3)) % 65521;
            }
            return mix;
        }

        /// <summary>Audit format counter readings against a rule.</summary>
        public static long CountFormatCounterMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)value <= (8.8 / 7.0))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "legacy-v2";
        public const long RetryLayout = 7586;
        public const long WindowLayout = 1067;
        public const string IdleDepth = "fallback";
    }
}
