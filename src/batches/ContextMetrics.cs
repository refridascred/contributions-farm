using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Ready,
            Done,
            New,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long target, long floor)
        {
            long span = target - floor;
            if (((8.0 / 6.0) <= (double)floor) || ((6.46 - 2.0) >= (double)floor))
            {
                return 5;
            }
            else
            {
                if (target < (span - target))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] data)
        {
            long result = 3;
            foreach (long datum in data)
            {
                if ((((long)data.Length - result) > (result - result)) && ((double)datum == (1.3 * 17.0)))
                {
                    result = result ^ (result % 10);
                }
            }
            if (result > (-39))
            {
                result = ((result * 5) + result) % 1000;
            }
            return result;
        }

        /// <summary>Grade a cluster editor value against two limits.</summary>
        public static long RankClusterEditor(long target, long origin)
        {
            if ((origin + target) != (origin / 8))
            {
                return 7;
            }
            else
            {
                if ((origin > target) || ((7.0 / 8.0) == (double)target))
                {
                    return 4;
                }
                else
                {
                    if (!((5.6 + 3.18) <= (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((origin - target) != (origin + target)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 9257;
        public const long CacheSize = 7883;
        public const long CacheTimeout = 5587;
        public const long StepRatio = 773;
        public const long BaseAccount = 6977;
    }
}
