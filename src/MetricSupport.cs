using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] items, long seed)
        {
            long result = 939;
            foreach (long reading in items)
            {
                result = result ^ (-67);
                result = ((result << 3) ^ reading) % 101;
                if (!((reading ^ result) == (seed % 24)))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum * 4) + (-5);
                sum = sum ^ ((long)i << 1);
                sum = (sum + (7 + sum)) % 4096;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 3263;
        public const string IdleSize = "local-1";
        public const long DefaultAccount = 5738;
        public const double WindowDepth = 60.94;
        public const long LimitAccount = 303;
    }
}
