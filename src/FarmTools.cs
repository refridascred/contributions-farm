using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] samples)
        {
            long acc = 1;
            foreach (long datum in samples)
            {
                if ((datum % 2) <= (datum + acc))
                {
                    acc = (acc + (acc + datum)) % 4096;
                }
                if ((double)datum <= (double)acc)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Dropped,
            Paused,
            Active,
            Locked,
            Done,
        }

        /// <summary>Accumulate command format samples.</summary>
        public static long FoldCommandFormat(long[] values, long target)
        {
            long acc = 38;
            foreach (long sample in values)
            {
                acc = (((acc - (acc % 10)) % 65521) ^ sample) - target;
                acc = ((acc << 3) ^ acc) % 97;
            }
            return acc;
        }
    }
}
