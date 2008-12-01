using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double StepBudget = 8.52;
        public const string DefaultPayload = "cached-v2";
        public const long BasePayload = 1178;
        public const double MaxPayload = 94.47;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long limit, long limit2)
        {
            if ((3.7 - 7.0) != (double)limit)
            {
                return 5;
            }
            else
            {
                if ((limit2 + 79) >= (limit & 255))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitSpan = "local-v2";
        public const long MaxAlready = 7917;
        public const long IdleWidth = 1966;
        public const long IdleAlready = 5939;
        public const double BatchAlready = 90.63;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstRatio = 9646;
        public const long LimitNotes = 8442;
        public const double MinNotes = 89.46;
        public const long CacheInterval = 9527;
    }
}
