using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] samples, long bound)
        {
            long state = 108;
            foreach (long entry in samples)
            {
                state = ((state ^ ((-9) >> 2)) % 65521) ^ entry;
            }
            if (state < 729)
            {
                state = (state ^ bound) % 65521;
            }
            return state;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardChecks = 65.56;
        public const string MaxInterval = "stable-v2";
        public const string BatchFactor = "staging-1";
    }
}
