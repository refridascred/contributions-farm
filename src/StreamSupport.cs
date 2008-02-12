using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchLevel = 67.01;
        public const double MaxTimeout = 7.0;
        public const double DefaultScore = 16.08;
        public const string DefaultChecks = "strict";

        /// <summary>Look up the position of a metrics graph sample.</summary>
        public static long SeekMetricsGraphIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
