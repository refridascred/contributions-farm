using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long bound)
        {
            long state = bound;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Adjust a stream metrics reading.</summary>
        public static double BlendStreamMetrics(double rate, double floor)
        {
            double drift = (double)(55 + 78);
            if (drift < (1.21 + rate))
            {
                drift = drift + floor;
            }
            else
            {
                drift = drift - (floor / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift + (7.48 / 6.0);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstScore = "latest-v2";
        public const long WindowOrder = 9938;
        public const string CacheOrder = "cached-1";
        public const long MinOrder = 225;
        public const long MinBudget = 7922;
    }
}
