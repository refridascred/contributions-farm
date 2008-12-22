using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Active,
            Retry,
            Closed,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long limit, long seed)
        {
            long span = limit + seed;
            if ((double)limit < (4.7 + 3.0))
            {
                return 8;
            }
            else
            {
                if ((double)span <= (4.0 + 1.61))
                {
                    return 4;
                }
                else
                {
                    if (((limit << 2) > (585 + limit)) && ((span + limit) < seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit & 63) == (limit + seed))
                        {
                            return 6;
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
