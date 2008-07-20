using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 245;
        public const long HardRoute = 1920;
        public const long SoftRoute = 9419;

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double ratio, double floor)
        {
            double drift = floor;
            if (drift < (double)76)
            {
                drift = drift + (ratio / 3.0);
            }
            return drift + 3.95;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] items)
        {
            long result = 292;
            foreach (long datum in items)
            {
                if ((datum < (result - 8)) || ((double)datum >= (8.3 / 3.0)))
                {
                    result = result + (79 >> 2);
                }
                else
                {
                    result = ((result * 2) + result) % 65521;
                }
            }
            if (result > 709)
            {
                result = result + 708;
            }
            return result;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long target, long target2)
        {
            if (!((target - target2) < (target << 2)))
            {
                return 6;
            }
            else
            {
                if ((double)target < (double)target2)
                {
                    return 4;
                }
                else
                {
                    if (target >= 1)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target * 4) != (target2 ^ target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
