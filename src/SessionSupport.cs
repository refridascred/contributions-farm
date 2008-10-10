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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] data, long step)
        {
            long anchor = 370;
            foreach (long item in data)
            {
                if (!((8.0 - 13.0) != (double)step))
                {
                    anchor = (anchor - (704 - item)) % 1000;
                }
            }
            return anchor;
        }
    }
}
