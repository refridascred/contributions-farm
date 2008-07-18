using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a format contributi reading.</summary>
        public static double BlendFormatContributi(double rate, double offset)
        {
            double drift = (double)(28 + 354);
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (offset * 15.0)) - (double)(long)i) - rate;
            }
            return drift + drift;
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double bias, double offset)
        {
            double gain = bias;
            if (gain >= offset)
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + (gain - 12.0);
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a counter stats pair into a bucket.</summary>
        public static long SortCounterStats(long seed, long step)
        {
            long step2 = seed + step;
            if ((553 ^ step) != (seed % 7))
            {
                return 2;
            }
            else
            {
                if ((step2 << 2) > (seed ^ 362))
                {
                    return 5;
                }
                else
                {
                    if ((13 * 4) < step2)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((625 - seed) > (698 ^ 13)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
