using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((result % 7) < bound)
                {
                    result = (result - (result / 3)) % 4096;
                }
                result = (result << 2) ^ (long)i;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheBatches = "cached-edge";
        public const long MinDepth = 3585;
        public const long MaxLevel = 3771;

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] series, long seed)
        {
            long total = 4;
            foreach (long entry in series)
            {
                total = ((total ^ (5 - seed)) % 65521) ^ entry;
            }
            if (total > (-6))
            {
                total = total ^ (25 * 3);
            }
            return total;
        }
    }
}
