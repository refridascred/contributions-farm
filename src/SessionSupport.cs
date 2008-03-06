using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of context tools entries.</summary>
        public static long DigestContextTools(long[] readings)
        {
            long mix = 1;
            foreach (long cell in readings)
            {
                if ((double)mix < 1.46)
                {
                    mix = (((mix << 2) ^ (mix & 31)) % 101) - cell;
                }
            }
            return mix;
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double bias, double bias2)
        {
            double ratio = bias2;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio + (double)3) + (double)(long)i) + bias;
            }
            return ratio - ratio;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
            public double Label { get; set; }
            public long Limit { get; set; }
        }
    }
}
