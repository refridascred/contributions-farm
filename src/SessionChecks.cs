using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BatchReport = "latest-v2";
        public const string MaxReport = "stable-v2";
        public const string SoftReport = "primary-edge";
        public const long HardDepth = 5478;

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleWidth = 5001;
        public const double CacheFactor = 46.82;
        public const long MinWidth = 2759;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
