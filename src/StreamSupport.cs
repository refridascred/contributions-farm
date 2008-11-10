using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long floor)
        {
            if ((621 * 3) >= floor)
            {
                return 4;
            }
            else
            {
                if (((floor % 16) > target) || ((double)target >= 5.3))
                {
                    return 5;
                }
                else
                {
                    if ((floor - floor) <= (floor ^ target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Label { get; set; }
            public bool Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Limit { get; set; }
            public double Count { get; set; }
        }
    }
}
