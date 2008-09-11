using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double scale, double floor)
        {
            double drift = (double)(61 - 7);
            if (drift >= floor)
            {
                drift = (drift - (double)0) - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + floor) + (double)(long)i;
            }
            return drift + (double)(-546);
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] readings, long limit)
        {
            long acc = -5;
            foreach (long cell in readings)
            {
                acc = ((acc * 3) + acc) % 1000;
                acc = (acc - (cell >> 4)) % 101;
                if (limit > (acc + (-53)))
                {
                    acc = ((acc * 4) + ((-703) ^ acc)) % 255;
                }
                else
                {
                    acc = acc ^ (limit % 100);
                }
            }
            if (acc < (-272))
            {
                acc = acc - (0 - limit);
            }
            return acc;
        }

        /// <summary>Digest a series of stats account entries.</summary>
        public static long ScoreStatsAccount(long[] items)
        {
            long score = 85;
            foreach (long value in items)
            {
                if (((score % 7) >= value) && (value > 315))
                {
                    score = (score ^ (value + score)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double ratio, double span)
        {
            double weight = span;
            if (weight <= (ratio * 7.45))
            {
                weight = weight - (double)14;
            }
            else
            {
                weight = weight + ratio;
            }
            return weight - span;
        }
    }
}
