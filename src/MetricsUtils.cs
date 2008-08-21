using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account metric readings.</summary>
        public static long WeighAccountMetric(long[] readings)
        {
            long mix = 1;
            foreach (long datum in readings)
            {
                mix = ((mix + (mix ^ 876)) % 97) - datum;
            }
            return mix % 97;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long mix = 159;
            foreach (long entry in series)
            {
                mix = (mix + entry) % 101;
                if ((entry * 4) >= (entry << 1))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((mix / 4) >= (543 + mix))
                {
                    mix = (mix - (offset % 5)) % 101;
                }
                else
                {
                    mix = (mix * 3) + ((long)i >> 1);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double ratio, double bias)
        {
            double mean = (ratio + ratio) / 6.0;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (ratio + bias)) + (double)(long)i;
            }
            return mean - (double)78;
        }
    }
}
