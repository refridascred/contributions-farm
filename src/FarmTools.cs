using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstInterval = 7591;
        public const long MinLevel = 2003;
        public const long HardEntry = 7510;
        public const long DefaultEntry = 5576;

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] levels)
        {
            long mark = 88;
            foreach (long value in levels)
            {
                if (((-77) ^ mark) == ((long)levels.Length % 12))
                {
                    mark = mark - value;
                }
                else
                {
                    mark = ((mark * 2) + (mark + mark)) % 1000;
                }
                if ((mark - mark) < (value + 4))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
