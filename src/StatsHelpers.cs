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

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
