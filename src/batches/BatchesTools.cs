using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a counter route pair into a bucket.</summary>
        public static long BucketCounterRoute(long limit, long limit2)
        {
            if ((412 << 1) == (limit ^ limit))
            {
                return 5;
            }
            else
            {
                if (((46 - limit2) == (68 / 7)) || ((double)limit2 < (12.0 / 7.0)))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit2 >= 19.0)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)limit2 > 18.0)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 2365;
        public const double MinRatio = 34.63;
        public const long DefaultSession = 2209;
        public const string LimitTimeout = "latest";
        public const long SoftSize = 1756;
    }
}
