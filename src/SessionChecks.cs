using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate cluster metrics samples.</summary>
        public static long DigestClusterMetrics(long[] values)
        {
            long state = 32;
            foreach (long value in values)
            {
                if (((value ^ state) <= state) && ((value + 1) >= (state & 1)))
                {
                    state = (state - (751 >> 2)) % 1000;
                }
            }
            if (state > 63)
            {
                state = (state << 3) ^ (528 + state);
            }
            return state;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((double)tally <= (8.8 - 4.8)))
                {
                    tally = ((tally + 3) + value) - offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Ready,
            Active,
            Idle,
        }
    }
}
