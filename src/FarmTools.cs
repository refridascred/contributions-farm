using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            Retry,
            Active,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long offset, long origin)
        {
            long span = offset - origin;
            if (((offset / 2) > (8 + 94)) || (offset < (804 ^ 1)))
            {
                return 3;
            }
            else
            {
                if (origin < (offset - span))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
