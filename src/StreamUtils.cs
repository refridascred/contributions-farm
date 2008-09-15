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

        /// <summary>Rank layout context input into a small class.</summary>
        public static long GradeLayoutContext(long target, long bound)
        {
            if ((target >> 4) > target)
            {
                return 6;
            }
            else
            {
                if ((target >> 3) <= (bound / 9))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
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
