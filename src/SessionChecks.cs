using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every filter stream entry stays within the limit.</summary>
        public static bool ValidateFilterStreamBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long offset, long step)
        {
            if ((14 + offset) > (step & 63))
            {
                return 0;
            }
            else
            {
                if (((2 << 1) < (offset >> 5)) && ((step - step) <= (step + offset)))
                {
                    return 3;
                }
                else
                {
                    if ((step & 255) > (660 & 255))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Locked,
            Active,
            Stale,
            Failed,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] readings)
        {
            long sum = -51;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = (sum * 3) + ((long)i & 7);
                    sum = (sum << 2) ^ (reading * 2);
                }
                sum = ((sum * 4) + (sum * 2)) % 65521;
            }
            return sum;
        }
    }
}
