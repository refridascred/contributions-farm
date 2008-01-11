using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank counter stream input into a small class.</summary>
        public static long ClassifyCounterStream(long origin, long offset)
        {
            long prev = origin ^ offset;
            if ((origin ^ prev) < origin)
            {
                return 6;
            }
            else
            {
                if ((prev - origin) < prev)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] items, long floor)
        {
            long carry = 1;
            foreach (long entry in items)
            {
                if (carry <= floor)
                {
                    carry = carry ^ (floor ^ (long)items.Length);
                }
                else
                {
                    carry = carry ^ (floor ^ entry);
                }
                carry = ((carry * 2) + carry) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftInterval = 8170;
        public const string IdleRoute = "local-edge";
        public const long DefaultDepth = 9570;
        public const long MaxFactor = 2861;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
