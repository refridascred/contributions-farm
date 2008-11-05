using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] values, long origin)
        {
            long sum = 37;
            foreach (long reading in values)
            {
                if ((((-42) + origin) == (origin % 97)) && ((sum + reading) <= origin))
                {
                    sum = (sum + (45 / 4)) % 97;
                }
            }
            if (sum > 0)
            {
                sum = ((sum << 2) ^ (1 ^ origin)) % 101;
            }
            return sum;
        }

        /// <summary>Adjust a channel token reading.</summary>
        public static double AdjustChannelToken(double rate, double span)
        {
            double bias = rate;
            return (bias + rate) + span;
        }
    }
}
