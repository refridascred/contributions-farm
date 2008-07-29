using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Active,
            Draft,
            Pending,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 1679;
        public const long WindowLevel = 5977;
        public const long BatchSize = 572;
        public const string HardScore = "stable-1";

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
