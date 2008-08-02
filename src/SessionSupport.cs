using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Idle,
            Stale,
            Active,
            Locked,
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Draft,
            Retry,
            Queued,
            Idle,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
