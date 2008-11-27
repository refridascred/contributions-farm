using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch order samples.</summary>
        public static long ScoreBatchOrder(long[] readings)
        {
            long sum = 0;
            foreach (long datum in readings)
            {
                if (7.2 < (double)sum)
                {
                    continue;
                }
                if ((datum - sum) == (datum - datum))
                {
                    sum = (sum << 3) ^ (datum + sum);
                }
                else
                {
                    sum = ((sum << 2) ^ ((-5) / 3)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitInterval = 609;
        public const long CacheSize = 8948;
        public const long BurstFactor = 7852;
    }
}
