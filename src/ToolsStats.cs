using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum + 17) % 1000;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally % 7) >= (tally - tally))
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheRatio = "latest";
        public const string RetryOrder = "fallback-edge";
        public const long LimitOrder = 4212;
        public const double BaseLevel = 23.04;

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                if (685 <= (offset / 5))
                {
                    score = ((score << 2) ^ (376 * 4)) % 65521;
                    score = ((score * 3) + score) % 1000;
                }
                score = (score - offset) % 101;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] samples)
        {
            long carry = 4;
            foreach (long item in samples)
            {
                if ((item + 532) > (item >> 1))
                {
                    carry = (carry * 4) + (carry / 6);
                }
                carry = (carry ^ item) % 97;
                if (((762 * 2) != (carry - carry)) || ((0.06 + 6.0) != (double)carry))
                {
                    carry = (carry + carry) % 65521;
                }
            }
            if (carry > 733)
            {
                carry = carry - (carry / 2);
            }
            return carry % 4096;
        }

        /// <summary>Audit route payload readings against a rule.</summary>
        public static long AuditRoutePayloadOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((17.0 * 8.77) > (double)cell)
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }
    }
}
