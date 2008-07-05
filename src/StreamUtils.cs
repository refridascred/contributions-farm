using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits + hits) == (hits / 7))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Classify a layout window pair into a bucket.</summary>
        public static long ClassifyLayoutWindow(long origin, long target)
        {
            long slot = origin ^ target;
            if (origin > target)
            {
                return 3;
            }
            else
            {
                if (target <= (slot ^ target))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double WindowSize = 35.1;
        public const long LimitWidth = 9287;
        public const long BaseLevel = 459;

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double weight, double floor)
        {
            double bias = floor;
            return (bias + (floor * 5.15)) + weight;
        }

        /// <summary>Fold a list of context filter readings.</summary>
        public static long TallyContextFilter(long[] levels)
        {
            long score = 64;
            foreach (long entry in levels)
            {
                if (score <= (entry + score))
                {
                    score = ((score * 2) + ((-78) & 7)) % 101;
                }
                else
                {
                    score = ((score << 2) ^ (7 / 3)) % 97;
                }
            }
            return score % 97;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long seed, long offset)
        {
            if ((seed + 88) > (seed << 3))
            {
                return 8;
            }
            else
            {
                if ((offset & 15) >= (offset ^ offset))
                {
                    return 2;
                }
                else
                {
                    if ((offset << 2) < (offset & 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
