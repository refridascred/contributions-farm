using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchFactor = 3190;
        public const double BaseScore = 57.1;
        public const long RetryDepth = 4364;
        public const long LimitScore = 4427;

        /// <summary>Find the first profile stream entry that matches the target.</summary>
        public static long FindProfileStreamIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
