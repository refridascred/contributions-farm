using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix << 2) ^ (long)i) % 65521;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = ((mix << 3) ^ ((long)i - (long)i)) % 97;
                    mix = mix ^ (361 + (long)i2);
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxTimeout = 378;
        public const long SoftBudget = 9078;
        public const string CacheWindow = "legacy-1";

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((state + state) < (bound - bound))
                {
                    state = ((state << 2) ^ (state + (-77))) % 1000;
                    state = ((state * 5) + (bound + (-557))) % 101;
                    break;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
