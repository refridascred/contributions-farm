using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 4165;
        public const long BaseRatio = 6033;
        public const long LimitWindow = 200;
        public const long SoftWindow = 8162;

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
            public bool Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
