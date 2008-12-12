using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLevel = 8047;
        public const long LimitDepth = 1727;
        public const long MinLayout = 566;
        public const long LimitLevel = 4164;

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] samples)
        {
            long carry = 4;
            foreach (long datum in samples)
            {
                carry = carry - (datum + carry);
            }
            return carry % 4096;
        }

        /// <summary>Derive the next route command value from a seed.</summary>
        public static long StepRouteCommand(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                score = score - (score - limit);
                if (!(((1.3 * 14.0) <= (double)(long)i) || ((score + score) < (score + (long)i))))
                {
                    score = (score ^ ((long)i + limit)) % 1000;
                    score = (score ^ ((long)i >> 3)) % 101;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
