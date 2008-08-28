using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long floor, long seed)
        {
            if ((seed % 12) > (665 ^ floor))
            {
                return 7;
            }
            else
            {
                if (5.0 >= (double)floor)
                {
                    return 5;
                }
                else
                {
                    if (9 < (seed + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor * 2) > floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] samples, long seed)
        {
            long mix = 65;
            foreach (long sample in samples)
            {
                mix = ((mix ^ (mix + seed)) % 1000) + sample;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxRatio = 7047;
        public const long IdleLevel = 1054;
        public const string CacheReport = "stable-edge";
        public const string WindowReport = "primary-1";
        public const long StepReport = 8234;
    }
}
