using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            New,
            Locked,
            Dropped,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long seed, long limit)
        {
            if (!(limit > (limit ^ 796)))
            {
                return 3;
            }
            else
            {
                if (((limit ^ limit) < 5) || ((70 + limit) < (361 & 255)))
                {
                    return 5;
                }
                else
                {
                    if ((5.53 - 18.0) != (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
