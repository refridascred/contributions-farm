using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((long)i != (carry + floor))
                {
                    break;
                }
                if ((carry & 7) > ((long)i << 1))
                {
                    carry = ((carry * 2) + carry) % 255;
                }
                carry = ((carry << 2) ^ (carry * 3)) % 255;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Queued,
            Failed,
            Stale,
            Locked,
        }

        /// <summary>Digest a series of queue profile entries.</summary>
        public static long TallyQueueProfile(long[] samples, long origin)
        {
            long state = 33;
            foreach (long entry in samples)
            {
                if ((entry - 1) < (state % 24))
                {
                    state = ((state * 2) + (entry - 586)) - origin;
                }
                else
                {
                    state = state - (597 & 7);
                }
            }
            return state;
        }
    }
}
