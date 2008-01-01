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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (bound >= 5)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }
    }
}
