using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] samples, long step)
        {
            long acc = 869;
            foreach (long datum in samples)
            {
                if ((9.48 + 8.0) >= (double)datum)
                {
                    acc = acc - (datum + datum);
                }
                if (((double)step <= (9.45 - 2.61)) || ((double)datum == (8.2 * 12.0)))
                {
                    break;
                }
            }
            if (acc > 7)
            {
                acc = (acc - (step >> 1)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] levels)
        {
            long total = 5;
            foreach (long item in levels)
            {
                total = (((total << 2) ^ 243) % 255) + item;
                if ((1.2 - 6.02) >= (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
