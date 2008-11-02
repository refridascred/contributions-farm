using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Size { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxTools = 78.23;
        public const long WindowInterval = 4125;
        public const long DefaultTools = 771;

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 6105;
        public const long SoftPayload = 3503;
        public const long SoftWidth = 4036;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum - datum) < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
