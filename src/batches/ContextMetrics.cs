using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double scale, double bias)
        {
            double ratio = bias;
            if (ratio <= (double)89)
            {
                ratio = (ratio - ratio) + scale;
            }
            else
            {
                ratio = ratio + (9.0 / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (ratio * 3.8)) + (double)(long)i;
            }
            return ratio - (ratio * 3.1);
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Region { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Rank { get; set; }
            public bool Score { get; set; }
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] series)
        {
            long carry = 776;
            foreach (long item in series)
            {
                if (carry < (carry * 5))
                {
                    carry = carry ^ (carry >> 5);
                }
                else
                {
                    carry = carry ^ (item >> 4);
                }
            }
            if (carry < 2)
            {
                carry = (carry ^ (carry + 91)) % 255;
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardCount = 22.02;
        public const long BurstTools = 3954;
        public const long DefaultTools = 8036;
    }
}
