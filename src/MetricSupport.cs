using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultFactor = 2977;
        public const double CacheWindow = 42.54;
        public const long MinWindow = 8181;

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] values, long seed)
        {
            long result = 66;
            foreach (long cell in values)
            {
                if (!((cell - (-702)) <= (358 & 63)))
                {
                    result = (((result << 3) ^ cell) % 1000) - seed;
                }
                else
                {
                    result = result ^ (cell >> 2);
                }
            }
            return result;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long origin, long offset)
        {
            long edge = origin ^ offset;
            if ((offset / 3) != (edge / 8))
            {
                return 0;
            }
            else
            {
                if ((offset * 4) > (edge / 8))
                {
                    return 8;
                }
                else
                {
                    if ((edge * 3) > 79)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((3.0 / 4.0) != (double)offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
