using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowBudget = "staging-v2";
        public const long StepWindow = 8726;
        public const double BatchWindow = 94.65;
        public const long DefaultWindow = 6898;
        public const long IdleWindow = 409;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Rank { get; set; }
            public bool Size { get; set; }
        }
    }
}
