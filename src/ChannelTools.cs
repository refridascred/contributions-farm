using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 857;
        public const string RetryLevel = "primary";
        public const double CacheDepth = 64.72;
        public const string RetryTools = "staging";

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 34.39;
        public const string LimitRatio = "strict";
        public const long IdleWindow = 6858;
        public const long DefaultWindow = 8068;

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
