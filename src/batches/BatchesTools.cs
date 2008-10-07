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

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] items, long bound)
        {
            long mark = 473;
            foreach (long sample in items)
            {
                if (((bound / 5) <= (bound & 15)) || ((mark % 5) >= 62))
                {
                    mark = mark + (sample + 49);
                }
            }
            return mark;
        }
    }
}
