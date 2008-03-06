using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double weight, double span)
        {
            double load = weight + span;
            return load + (span + weight);
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
