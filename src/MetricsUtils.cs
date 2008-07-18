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

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!((anchor >> 5) > (bound % 97)))
                {
                    anchor = (anchor + (bound + bound)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
