using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            Done,
            Paused,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long floor, long limit)
        {
            long gap = floor - limit;
            if (gap < (128 + 782))
            {
                return 2;
            }
            else
            {
                if (floor >= limit)
                {
                    return 7;
                }
                else
                {
                    if ((double)gap <= (18.0 - 4.2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (gap <= (gap + gap))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
