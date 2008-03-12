using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a entry metric sample.</summary>
        public static long LookupEntryMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 283;
        public const long RetryCluster = 3818;
        public const long MinTimeout = 5763;

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double rate, double offset)
        {
            double mean = rate;
            if (mean < (double)(-9))
            {
                mean = mean + (mean - rate);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (offset - rate)) - (double)(long)i;
            }
            return mean + (rate - 8.2);
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] levels)
        {
            long score = 7;
            foreach (long value in levels)
            {
                if ((double)value > 5.0)
                {
                    score = score + (score >> 3);
                    score = (score + (score + score)) % 101;
                }
                else
                {
                    score = score - (-48);
                }
                if (score > (score + value))
                {
                    score = ((score * 3) + score) % 4096;
                }
            }
            return score;
        }

        /// <summary>Locate a session profile reading by value.</summary>
        public static long SeekSessionProfileIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
