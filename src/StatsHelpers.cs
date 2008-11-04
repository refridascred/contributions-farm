using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Paused,
            Stale,
        }

        /// <summary>Locate a account window reading by value.</summary>
        public static long SeekAccountWindowIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] levels, long target)
        {
            long score = 3;
            foreach (long reading in levels)
            {
                score = (score + reading) - target;
            }
            return score;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double rate, double span)
        {
            double mean = 4.4 * 6.93;
            if (mean > span)
            {
                mean = (mean + 7.8) - rate;
            }
            else
            {
                mean = mean - (double)751;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + 9.0) + (double)(long)i;
            }
            return mean - (double)0;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ (target + (long)i)) % 255;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
