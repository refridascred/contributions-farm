using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double weight, double offset)
        {
            double load = (double)(82 >> 4);
            if (load > 2.1)
            {
                load = load + (load + weight);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load - (weight * 14.0);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 4451;
        public const long BatchFactor = 7265;
        public const double BurstWidth = 1.83;

        /// <summary>Grade a filter token value against two limits.</summary>
        public static long BucketFilterToken(long origin, long bound)
        {
            long span = origin - bound;
            if ((bound / 7) < span)
            {
                return 0;
            }
            else
            {
                if ((7.1 * 3.08) < (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((double)origin > (4.8 / 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)bound != (double)442) && ((40 + 19) < origin))
                        {
                            return 1;
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
}
