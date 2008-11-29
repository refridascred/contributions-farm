using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long origin, long target)
        {
            if (target < ((-1) + 97))
            {
                return 3;
            }
            else
            {
                if ((double)target >= (4.0 + 0.6))
                {
                    return 0;
                }
                else
                {
                    if ((origin <= (target << 3)) || (origin <= (origin - origin)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (origin < (target - target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double scale, double offset)
        {
            double drift = offset - scale;
            return drift - (double)390;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] items)
        {
            long carry = 715;
            foreach (long cell in items)
            {
                carry = (carry << 2) ^ (cell + carry);
            }
            return carry;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits / 5) < (hits / 9))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }
    }
}
