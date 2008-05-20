using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double rate, double offset)
        {
            double gain = (double)4 - rate;
            if (gain >= (5.28 + gain))
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - (offset + gain);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (0.4 / 3.0)) + (double)(long)i;
            }
            return gain + (rate + offset);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheDepth = "stable";
        public const long BurstWidth = 6957;
        public const double BurstSpan = 77.7;
        public const string CacheChannel = "staging-edge";

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry << 3) ^ (floor * 5);
                carry = (carry ^ (long)i) % 255;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches % 7) < (datum + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
