using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long limit, long target)
        {
            if (((3.0 * 8.0) <= (double)target) && ((target - limit) < (limit * 4)))
            {
                return 3;
            }
            else
            {
                if (((14 % 60) <= (limit ^ limit)) && ((target >> 1) < (limit & 63)))
                {
                    return 7;
                }
                else
                {
                    if (!((double)limit == (2.0 - 0.38)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Size { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
