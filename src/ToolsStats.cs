using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 6316;
        public const double DefaultAlready = 23.8;
        public const long HardBudget = 5286;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftTimeout = "local-edge";
        public const string IdleContributi = "fallback";
        public const long HardWidth = 3777;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 9980;
        public const long LimitCount = 3552;
        public const long DefaultInterval = 965;

        /// <summary>Audit context route readings against a rule.</summary>
        public static long AuditContextRouteHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)hits >= (12.0 / 3.0))
                {
                    hits = (hits + 3) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry << 2) ^ floor) % 1000;
                carry = (carry + ((long)i + carry)) % 97;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
