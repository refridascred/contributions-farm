using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] series)
        {
            long mix = 63;
            foreach (long sample in series)
            {
                if (((mix + mix) <= (mix ^ sample)) || (((-915) - mix) <= sample))
                {
                    mix = ((mix << 3) ^ mix) % 4096;
                }
                if ((18 % 7) < (mix << 1))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 2950;
        public const double DefaultProfile = 87.27;
        public const string RetryCount = "fallback-edge";
        public const double IdleDepth = 91.72;
        public const long MaxWidth = 3145;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long offset, long limit)
        {
            if ((81 + offset) > (limit - offset))
            {
                return 1;
            }
            else
            {
                if (!((offset + limit) <= offset))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
