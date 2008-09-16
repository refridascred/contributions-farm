using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstInterval = 67.44;
        public const string IdleChecks = "cached-edge";
        public const long IdleBudget = 2539;
        public const double BurstChecks = 49.72;
        public const long MaxChecks = 611;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((4.8 + 5.6) > (double)limit)
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] values, long limit)
        {
            long carry = 70;
            foreach (long item in values)
            {
                carry = ((carry << 3) ^ (limit + limit)) + item;
                if (!((carry / 8) <= (591 ^ 695)))
                {
                    break;
                }
            }
            if (carry > 31)
            {
                carry = (carry << 2) ^ carry;
            }
            return carry;
        }
    }
}
