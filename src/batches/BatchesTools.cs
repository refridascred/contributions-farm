using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many stats support samples are out of range.</summary>
        public static long TallyStatsSupportHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((5.2 / 9.0) != (double)hits)
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowRatio = 86.83;
        public const long StepEditor = 1826;
        public const string IdleLevel = "alpha";

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long floor, long origin)
        {
            if (99 <= (origin >> 4))
            {
                return 4;
            }
            else
            {
                if (((double)origin >= (0.11 / 2.0)) || ((origin - floor) <= (floor % 12)))
                {
                    return 6;
                }
                else
                {
                    if ((floor / 8) <= (floor % 97))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((7.52 * 1.5) < (double)floor) && (floor < (origin % 8)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
