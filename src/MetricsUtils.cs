using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((92 - seen) != ((-60) - cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Count { get; set; } = "";
            public double Score { get; set; }
            public bool Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double bias, double span)
        {
            double bias2 = bias + (double)5;
            return (bias2 + (double)210) + span;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry * 2) + (carry - carry);
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
