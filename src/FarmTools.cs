using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double gain, double span)
        {
            double weight = 3.0 / 3.0;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - (weight + gain)) + (double)(long)i) - span;
            }
            return weight + gain;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((double)seed >= (10.0 + 8.85))
                {
                    continue;
                }
                else
                {
                    mark = mark - (seed << 1);
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 4574;
        public const long SoftQueue = 7120;
        public const double IdleLevel = 82.59;
    }
}
