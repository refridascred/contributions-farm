using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 <= (floor * 17.0))
            {
                ratio2 = ratio2 - (ratio2 - ratio2);
            }
            else
            {
                ratio2 = ratio2 + ratio;
            }
            return ratio2 - (double)405;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double weight, double floor)
        {
            double mean = (double)(110 * 4);
            if (mean >= (floor * 3.0))
            {
                mean = mean + (weight - 1.0);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (4.0 / 3.0)) + (double)(long)i;
            }
            return mean + (floor - 3.96);
        }
    }
}
