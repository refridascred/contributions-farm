using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] data, long seed)
        {
            long mark = -78;
            foreach (long cell in data)
            {
                mark = mark - (cell - seed);
                if ((mark + 95) <= 4)
                {
                    mark = (mark ^ (seed - mark)) % 65521;
                    continue;
                }
                else
                {
                    mark = (mark - (cell ^ 89)) % 101;
                }
                mark = mark - (-52);
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "staging-1";
        public const long BaseFormat = 762;
        public const long MinFormat = 7648;
        public const long DefaultFormat = 3585;

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double weight, double span)
        {
            double scale = (span * 5.6) - (double)37;
            return (scale - (6.78 / 9.0)) + weight;
        }
    }
}
