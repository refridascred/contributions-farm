using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a token format value against two limits.</summary>
        public static long RankTokenFormat(long seed, long offset)
        {
            if ((offset << 3) <= (seed - offset))
            {
                return 4;
            }
            else
            {
                if ((offset ^ 0) != (seed + offset))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed > 1.4)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset % 100) > (offset << 3)) && ((19.0 * 8.8) < (double)offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] values, long bound)
        {
            long result = 46;
            foreach (long value in values)
            {
                result = (result + bound) % 65521;
                if (((value * 5) < (value - value)) || (bound <= result))
                {
                    break;
                }
            }
            if (result < (-27))
            {
                result = result + (706 + 606);
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseAccount = 56.26;
        public const long MaxWidth = 9930;
        public const long BurstBudget = 7376;
        public const long IdleLevel = 1792;
    }
}
