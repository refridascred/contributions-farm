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

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long limit, long step)
        {
            long lane = limit - step;
            if ((limit ^ lane) <= ((-4) % 3))
            {
                return 1;
            }
            else
            {
                if (((1.8 * 6.5) <= (double)step) && (lane <= (438 + step)))
                {
                    return 2;
                }
                else
                {
                    if (((-73) >> 2) == (step % 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
