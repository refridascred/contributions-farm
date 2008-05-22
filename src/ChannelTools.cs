using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many window batch samples are out of range.</summary>
        public static long AuditWindowBatchGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches - matches) < (6 ^ matches))
                {
                    matches = ((matches + 3) - item) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the order graph entries that pass the check.</summary>
        public static long CountOrderGraphMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum < (seen - seen)) && ((double)datum < (0.9 + 11.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Active,
            Idle,
            Ready,
            Queued,
        }
    }
}
