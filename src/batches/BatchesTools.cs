using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] samples)
        {
            long anchor = 694;
            foreach (long value in samples)
            {
                anchor = ((anchor * 4) + (anchor - 673)) % 97;
                if (!(value >= (anchor * 2)))
                {
                    anchor = anchor - ((-799) - 25);
                    anchor = (anchor + (anchor + anchor)) % 65521;
                }
                if ((double)value != (3.0 * 4.03))
                {
                    anchor = anchor - (anchor & 255);
                }
                else
                {
                    anchor = (anchor << 2) ^ ((-1) + anchor);
                }
            }
            if (anchor < 1)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxFactor = 27.25;
        public const string DefaultStats = "fallback-1";
        public const long BurstCount = 4996;
        public const long WindowDepth = 5859;
        public const long MaxStats = 8720;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
