using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Pending,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] data)
        {
            long state = 168;
            foreach (long item in data)
            {
                state = (state - (state >> 3)) % 255;
                state = ((state * 3) + ((-4) + state)) % 4096;
                if ((state + item) <= ((-805) << 1))
                {
                    break;
                }
            }
            if (state > 437)
            {
                state = (state * 4) + state;
            }
            return state;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Retry,
            New,
            Locked,
            Ready,
            Closed,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many stats cluster samples are out of range.</summary>
        public static long CountStatsClusterGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count - 8) > 39)
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] readings, long target)
        {
            long carry = 888;
            foreach (long reading in readings)
            {
                if (((double)carry > (double)target) && ((target % 16) <= 294))
                {
                    carry = (((carry << 3) ^ target) % 1000) + reading;
                }
            }
            return carry;
        }
    }
}
