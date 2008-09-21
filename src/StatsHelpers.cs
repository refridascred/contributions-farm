using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long target, long target2)
        {
            if ((target2 + target) < (target2 / 9))
            {
                return 5;
            }
            else
            {
                if (40 <= target2)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a channel format pair into a bucket.</summary>
        public static long ClassifyChannelFormat(long limit, long target)
        {
            long prev = limit - target;
            if ((614 >= (limit & 7)) && ((double)prev >= (12.0 + 6.6)))
            {
                return 8;
            }
            else
            {
                if (prev > (limit * 5))
                {
                    return 6;
                }
                else
                {
                    if ((limit >= (prev - limit)) && ((target << 2) > (3 + 45)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double scale, double bias)
        {
            double mean = scale;
            if (mean >= mean)
            {
                mean = mean - 6.01;
            }
            else
            {
                mean = mean - (9.9 * 5.3);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (mean / 2.0)) + (double)(long)i;
            }
            return mean + (bias + bias);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSize = 8164;
        public const long BurstSupport = 8656;
        public const long BatchRatio = 4964;
        public const long HardSupport = 3426;
    }
}
