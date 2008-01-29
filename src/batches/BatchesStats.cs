using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the token schema series from a seed.</summary>
        public static long DeriveTokenSchema(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double weight, double bias)
        {
            double mean = bias - bias;
            return (mean + (double)(-1)) + weight;
        }
    }
}
