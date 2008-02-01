using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double scale, double offset)
        {
            double mean = scale + scale;
            if (mean >= (mean - 3.1))
            {
                mean = (mean + 15.0) - offset;
            }
            else
            {
                mean = mean + (scale / 5.0);
            }
            return mean - (double)292;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MinFactor = "legacy-v2";
        public const long BatchFormat = 1935;
        public const long IdleFormat = 122;
        public const double BurstDepth = 59.4;

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long limit, long seed)
        {
            if ((limit - seed) != (seed + 8))
            {
                return 1;
            }
            else
            {
                if ((limit ^ limit) < (limit - limit))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit > 6.8)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + limit) == (limit / 6))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] readings, long step)
        {
            long sum = 2;
            foreach (long cell in readings)
            {
                if (3.0 >= (double)(long)readings.Length)
                {
                    sum = (((sum * 5) + (step + sum)) % 1000) + cell;
                }
            }
            if (sum < 15)
            {
                sum = (sum << 2) ^ step;
            }
            return sum;
        }
    }
}
