using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long target, long target2)
        {
            if ((target + target2) >= (target2 ^ target))
            {
                return 8;
            }
            else
            {
                if ((double)target == (8.4 / 9.0))
                {
                    return 7;
                }
                else
                {
                    if (target2 > (target - target2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)target2 != (5.77 / 8.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardSize = 104;
        public const long BatchSize = 1402;
        public const double StepMetrics = 56.42;
        public const long MaxTimeout = 921;
    }
}
