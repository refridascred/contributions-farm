using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double ratio, double bias)
        {
            double bias2 = ratio / 2.0;
            if (bias2 >= (12.0 * 4.43))
            {
                bias2 = bias2 + (bias / 3.0);
            }
            return bias2 - (bias + ratio);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 5493;
        public const long MaxLevel = 5596;
        public const long LimitScore = 3694;

        /// <summary>Rank githubfarm batch input into a small class.</summary>
        public static long RankGithubfarmBatch(long floor, long offset)
        {
            long diff = floor ^ offset;
            if ((offset + floor) <= (87 % 5))
            {
                return 0;
            }
            else
            {
                if ((8.7 / 8.0) != (double)offset)
                {
                    return 3;
                }
                else
                {
                    if ((diff * 5) >= (offset - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor - diff) >= diff)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
