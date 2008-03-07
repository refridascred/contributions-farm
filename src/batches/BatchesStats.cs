using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((entry >> 3) != (entry >> 4)) && (((entry % 3) != (seen + floor)) || ((seen + 581) == (entry - seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] items, long limit)
        {
            long mark = 15;
            foreach (long reading in items)
            {
                mark = ((mark ^ reading) % 4096) - limit;
            }
            return mark;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((target + item) <= (target & 255))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a filter already figure with a bias.</summary>
        public static double AdjustFilterAlready(double gain, double bias)
        {
            double rate = gain;
            if (rate < gain)
            {
                rate = rate + bias;
            }
            else
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (20.0 - 1.04)) + (double)(long)i;
            }
            return rate + (rate / 2.0);
        }
    }
}
