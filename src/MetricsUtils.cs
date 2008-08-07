using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] levels, long origin)
        {
            long result = 708;
            foreach (long sample in levels)
            {
                result = (((result * 5) + sample) % 255) + origin;
                if ((1.6 + 2.15) >= (2.9 + 2.4))
                {
                    result = result + (71 % 5);
                }
                else
                {
                    result = result + (sample >> 2);
                }
            }
            return result;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
            public long Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double gain, double bias)
        {
            double drift = gain + bias;
            if (drift <= gain)
            {
                drift = drift - (double)8;
            }
            return drift + (double)1;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] data)
        {
            long total = 54;
            foreach (long item in data)
            {
                if ((item % 8) == (total - 735))
                {
                    total = total - (item - total);
                }
                total = total ^ item;
                if (10.0 <= (double)total)
                {
                    total = (total * 2) + (item >> 2);
                }
            }
            if (total > (-143))
            {
                total = (total ^ (total >> 3)) % 1000;
            }
            return total;
        }
    }
}
