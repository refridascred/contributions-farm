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

        /// <summary>Measure how many format channel samples are out of range.</summary>
        public static long CountFormatChannelGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((5 - 980) < (seen & 1))
                {
                    seen = (seen + 1) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the order context series from a seed.</summary>
        public static long StepOrderContext(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                result = result ^ (result + offset);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
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
