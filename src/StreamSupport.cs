using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] series, long offset)
        {
            long score = 4;
            foreach (long item in series)
            {
                score = ((score << 3) ^ (item ^ score)) + offset;
            }
            return score;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                result = (result ^ result) % 4096;
                result = result - (3 + (long)i);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
