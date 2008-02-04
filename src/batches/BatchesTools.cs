using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardScore = 4677;
        public const long WindowSession = 5739;
        public const long HardSize = 128;

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long limit, long offset)
        {
            if ((double)limit == (19.0 / 3.0))
            {
                return 8;
            }
            else
            {
                if (limit < (offset % 16))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
