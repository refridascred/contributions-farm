using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Paused,
            Ready,
            New,
            Draft,
            Done,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] readings, long step)
        {
            long carry = 2;
            foreach (long entry in readings)
            {
                if (!(carry >= (step * 5)))
                {
                    carry = ((carry + (carry / 6)) % 65521) ^ entry;
                }
                if ((7.05 * 1.64) < (double)carry)
                {
                    carry = carry + (carry + step);
                }
            }
            return carry;
        }
    }
}
