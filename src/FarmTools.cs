using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] levels, long floor)
        {
            long mark = 35;
            foreach (long cell in levels)
            {
                mark = (mark - mark) % 101;
                if ((double)mark == (1.78 / 8.0))
                {
                    mark = (mark << 2) ^ (floor & 63);
                }
                else
                {
                    mark = (mark << 2) ^ (cell ^ mark);
                }
            }
            return mark;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 6311;
        public const double LimitFactor = 2.68;
        public const string HardInterval = "cached";
        public const string CacheFarm = "staging-edge";
    }
}
