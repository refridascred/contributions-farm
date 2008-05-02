using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] items, long seed)
        {
            long acc = 39;
            foreach (long sample in items)
            {
                acc = ((acc + (18 >> 5)) % 101) + sample;
                acc = (acc ^ seed) % 101;
            }
            if (acc > 37)
            {
                acc = acc + (8 + 56);
            }
            return acc;
        }
    }
}
