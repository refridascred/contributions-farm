using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Pending,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstSpan = 9499;
        public const long SoftBuffer = 371;
        public const string WindowInterval = "local";
        public const long IdleFactor = 510;
        public const double StepLevel = 98.77;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
