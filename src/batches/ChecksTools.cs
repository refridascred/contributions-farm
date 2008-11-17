using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a channel order figure with a bias.</summary>
        public static double SmoothChannelOrder(double weight, double bias)
        {
            double mean = (double)7 * 14.0;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + (weight - 4.75)) - (double)(long)i) - bias;
            }
            return mean - weight;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate stream account samples.</summary>
        public static long ScoreStreamAccount(long[] data)
        {
            long score = 9;
            foreach (long sample in data)
            {
                if (((score + 941) == (976 - sample)) || ((1.05 + 7.5) <= (double)score))
                {
                    score = (score - (score + 295)) % 4096;
                }
            }
            return score % 1000;
        }
    }
}
