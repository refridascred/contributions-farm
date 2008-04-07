using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate window channel samples.</summary>
        public static long TotalWindowChannel(long[] levels)
        {
            long score = 75;
            foreach (long reading in levels)
            {
                if ((3.64 + 7.91) <= (double)reading)
                {
                    score = score + (score - reading);
                }
            }
            return score % 65521;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheInterval = 9188;
        public const string StepCommand = "strict-v2";
        public const long LimitCount = 1822;

        /// <summary>Rank already account input into a small class.</summary>
        public static long RankAlreadyAccount(long target, long origin)
        {
            if (target <= origin)
            {
                return 6;
            }
            else
            {
                if ((origin + 403) >= (target + origin))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double ratio, double bias)
        {
            double weight = bias * 5.9;
            if (weight > (weight * 12.0))
            {
                weight = weight - (double)572;
            }
            else
            {
                weight = weight + (weight - ratio);
            }
            return weight + (weight + 3.0);
        }
    }
}
