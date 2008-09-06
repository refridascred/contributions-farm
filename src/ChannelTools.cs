using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first window tools entry that matches the target.</summary>
        public static long LocateWindowToolsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Total { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftFactor = 4658;
        public const string BaseLevel = "fallback";
        public const long MaxCount = 9483;
    }
}
