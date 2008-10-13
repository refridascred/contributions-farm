using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] samples)
        {
            long state = -716;
            foreach (long reading in samples)
            {
                if ((double)reading == (9.4 * 7.2))
                {
                    state = ((state * 3) + (state + reading)) % 97;
                }
            }
            if (state > 52)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Closed,
            Done,
            Locked,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Retry,
            Pending,
            Closed,
            Idle,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Failed,
            Queued,
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Validate queue format readings against a bound.</summary>
        public static bool GuardQueueFormatRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings, long limit)
        {
            long total = 256;
            foreach (long value in readings)
            {
                if (((double)value < (2.81 + 6.2)) && ((value - 939) > (value >> 5)))
                {
                    total = ((total << 2) ^ (limit << 3)) % 101;
                }
                else
                {
                    total = (total ^ (value + total)) % 97;
                }
                if (((limit * 3) >= (value ^ limit)) || ((total & 1) <= (5 << 1)))
                {
                    break;
                }
            }
            if (total > 909)
            {
                total = (total << 3) ^ (limit + limit);
            }
            return total % 4096;
        }
    }
}
