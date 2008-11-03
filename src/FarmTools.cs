using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next layout filter value.</summary>
        public static double AdjustLayoutFilter(double bias, double offset)
        {
            double bias2 = (offset - offset) / 2.0;
            if (bias2 < (bias / 9.0))
            {
                bias2 = bias2 + (double)131;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (10.0 + bias)) - (double)(long)i;
            }
            return bias2 - (bias - bias);
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((87 < (matches - cell)) || (((floor % 24) == (cell >> 3)) && ((floor ^ matches) >= matches)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Total { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
