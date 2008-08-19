using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long bound, long limit)
        {
            if ((9.0 / 4.0) != (double)bound)
            {
                return 2;
            }
            else
            {
                if ((bound - bound) >= (bound ^ bound))
                {
                    return 1;
                }
                else
                {
                    if (!(limit >= bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound & 7) != (bound + 423))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits + sample) <= 27)
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 2197;
        public const double HardRatio = 48.19;
        public const long SoftContext = 3031;
    }
}
