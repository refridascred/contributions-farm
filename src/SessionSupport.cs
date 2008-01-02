using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 6385;
        public const long IdleDepth = 6796;
        public const string DefaultInterval = "open-edge";

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
