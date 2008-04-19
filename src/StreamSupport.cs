using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstDepth = 4587;
        public const long LimitBudget = 4487;
        public const string DefaultFactor = "staging-v2";
        public const long BatchScore = 4653;

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((double)score <= 9.6)
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate schema route readings against a bound.</summary>
        public static bool GuardSchemaRouteBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
