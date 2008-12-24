using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BaseWidth = "stable-v2";
        public const long LimitScore = 2859;
        public const double StepSession = 90.25;
        public const long HardSession = 2142;
        public const string BatchSpan = "open-edge";

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Rank { get; set; }
            public bool Offset { get; set; }
        }
    }
}
