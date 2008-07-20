using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double rate, double floor)
        {
            double bias = rate;
            if (bias > (5.3 * 9.0))
            {
                bias = bias - rate;
            }
            return bias + floor;
        }

        /// <summary>Look up the position of a cache command sample.</summary>
        public static long SeekCacheCommandIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph cluster readings against a rule.</summary>
        public static long CountGraphClusterOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading ^ reading) == (reading + seed))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double rate, double span)
        {
            double bias = span;
            if (bias > 5.65)
            {
                bias = bias + bias;
            }
            return bias + (rate + 6.83);
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] readings)
        {
            long score = 70;
            foreach (long cell in readings)
            {
                if (((6 + 62) >= (796 + cell)) || ((7.6 / 9.0) <= (double)cell))
                {
                    score = (score << 3) ^ (score - cell);
                }
                else
                {
                    score = (score - (120 + cell)) % 255;
                }
            }
            return score % 1000;
        }
    }
}
