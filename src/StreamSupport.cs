using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a entry context value against two limits.</summary>
        public static long SortEntryContext(long limit, long bound)
        {
            if ((9.87 * 8.8) != (double)limit)
            {
                return 3;
            }
            else
            {
                if ((double)limit == (4.7 / 7.0))
                {
                    return 8;
                }
                else
                {
                    if ((limit + limit) == (bound * 2))
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

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Retry,
            Draft,
            Synced,
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Count { get; set; }
            public bool Offset { get; set; }
        }
    }
}
