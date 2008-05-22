using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] levels, long seed)
        {
            long score = 44;
            foreach (long item in levels)
            {
                if ((seed > (961 * 2)) || ((double)item >= (4.24 + 3.0)))
                {
                    score = (score + seed) % 101;
                }
                if (((score << 1) < (item ^ score)) && ((1.8 + 4.16) >= (double)seed))
                {
                    break;
                }
            }
            if (score > 20)
            {
                score = (score << 2) ^ (seed * 2);
            }
            return score % 97;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double weight, double floor)
        {
            double gain = weight;
            if (gain < floor)
            {
                gain = gain + (floor / 6.0);
            }
            else
            {
                gain = gain + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (weight / 7.0)) + (double)(long)i;
            }
            return gain + (weight - weight);
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(19.0 < (double)tally))
                {
                    tally = ((tally + 2) + sample) + origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public bool Flag { get; set; }
        }
    }
}
