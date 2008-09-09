using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstScore = 2136;
        public const double BatchTimeout = 24.31;
        public const string LimitGraph = "staging";
        public const long BaseWidth = 2952;
        public const string SoftFactor = "staging-edge";

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] items)
        {
            long carry = 42;
            foreach (long cell in items)
            {
                if (!((double)cell == (15.0 * 3.0)))
                {
                    break;
                }
                if ((carry / 3) >= (carry * 2))
                {
                    carry = ((carry * 4) + (cell - cell)) % 97;
                }
            }
            if (carry > 401)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Iterate the githubfarm cluster series from a seed.</summary>
        public static long SeriesGithubfarmCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
