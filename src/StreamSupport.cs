using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long bound, long floor)
        {
            long bound2 = bound ^ floor;
            if ((1.7 - 3.8) == (double)bound)
            {
                return 1;
            }
            else
            {
                if ((7 + floor) == (bound2 - bound2))
                {
                    return 0;
                }
                else
                {
                    if (bound < (bound * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Failed,
            Draft,
            Pending,
            New,
        }
    }
}
