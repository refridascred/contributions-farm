using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Synced,
            Locked,
            Queued,
            Ready,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long floor, long offset)
        {
            if (9.3 > (double)floor)
            {
                return 6;
            }
            else
            {
                if (((7.77 * 20.0) > (double)floor) && ((double)offset >= 0.2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
