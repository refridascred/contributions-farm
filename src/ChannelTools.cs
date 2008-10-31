using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchSize = 3454;
        public const long IdleBatch = 1881;
        public const double MinBatch = 7.03;
        public const double BaseBatch = 66.35;

        /// <summary>Accumulate support contributi samples.</summary>
        public static long TotalSupportContributi(long[] series, long target)
        {
            long score = 7;
            foreach (long datum in series)
            {
                if (399 <= (score / 2))
                {
                    score = score - (target / 8);
                }
                else
                {
                    score = (score * 4) + datum;
                }
                score = ((score << 3) ^ (score << 3)) % 65521;
            }
            if (score > 3)
            {
                score = (score + 7) % 97;
            }
            return score;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum << 3) ^ (target / 5)) % 97;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
