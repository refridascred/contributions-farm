using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowTimeout = 8756;
        public const double StepStats = 6.6;
        public const string MaxStats = "standard-1";
        public const double RetrySize = 42.42;

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Total { get; set; }
            public string Level { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
