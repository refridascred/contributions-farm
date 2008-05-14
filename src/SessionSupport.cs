using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Level { get; set; }
            public bool Size { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 5177;
        public const long HardDepth = 4148;
        public const string SoftSize = "strict-v2";
        public const long CacheCommand = 41;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long offset, long bound)
        {
            long gap = offset - bound;
            if (gap >= (gap >> 5))
            {
                return 2;
            }
            else
            {
                if (!((547 ^ gap) != (677 + 2)))
                {
                    return 7;
                }
                else
                {
                    if (offset < (gap * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
