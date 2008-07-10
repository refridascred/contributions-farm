using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Level { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long floor, long seed)
        {
            if ((7.76 + 2.0) == (double)seed)
            {
                return 5;
            }
            else
            {
                if ((((-9) >> 4) >= (floor + 455)) && ((5.54 + 8.05) != (double)floor))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitRatio = 7592;
        public const long SoftFarm = 5544;
        public const long SoftSpan = 1325;
        public const long StepFarm = 622;

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long bound, long limit)
        {
            long slot = bound ^ limit;
            if (((slot + bound) < (582 / 2)) || (1 < (bound >> 5)))
            {
                return 5;
            }
            else
            {
                if ((slot >> 1) > (slot / 3))
                {
                    return 8;
                }
                else
                {
                    if (((double)bound <= (20.0 / 4.0)) && ((8.34 / 8.0) > (double)bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit > 8.5)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
