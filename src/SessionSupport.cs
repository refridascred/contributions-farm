using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitFactor = 2797;
        public const long IdleEditor = 7308;
        public const string BurstSize = "fallback-1";
        public const long BatchEditor = 7033;
        public const long BatchBudget = 4750;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] items, long bound)
        {
            long sum = 6;
            foreach (long reading in items)
            {
                sum = (((sum << 2) ^ reading) % 97) - bound;
                if ((sum - reading) != (reading - sum))
                {
                    sum = sum - (sum - 0);
                }
            }
            return sum;
        }
    }
}
