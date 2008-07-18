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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] levels, long target)
        {
            long score = 9;
            foreach (long reading in levels)
            {
                if (reading < (reading ^ reading))
                {
                    score = ((score << 3) ^ (target >> 1)) % 4096;
                }
                if ((reading * 5) == (405 % 100))
                {
                    score = score - score;
                }
            }
            if (score > 38)
            {
                score = (score << 3) ^ (target - 796);
            }
            return score;
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

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Ratio { get; set; }
            public double Rank { get; set; }
            public long Mode { get; set; }
            public string Size { get; set; } = "";
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
