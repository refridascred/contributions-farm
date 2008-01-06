using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of entry filter entries.</summary>
        public static long DigestEntryFilter(long[] readings)
        {
            long score = 866;
            foreach (long datum in readings)
            {
                score = (score * 3) + (datum + score);
                if (((datum + datum) <= (datum + score)) && ((17.0 + 6.87) > (double)datum))
                {
                    score = score + (score * 4);
                }
            }
            return score % 1000;
        }

        /// <summary>Blend two batches profile measurements.</summary>
        public static double AdjustBatchesProfile(double ratio, double bias)
        {
            double scale = bias;
            if (scale >= (double)(-33))
            {
                scale = (scale - (3.6 / 3.0)) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (0.39 / 8.0)) - (double)(long)i;
            }
            return scale - (bias * 19.0);
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)value > 0.8)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long origin, long step)
        {
            if ((step / 9) < (step + step))
            {
                return 7;
            }
            else
            {
                if (!((step + 44) > (step / 5)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate metrics channel readings against a bound.</summary>
        public static bool VerifyMetricsChannelRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
