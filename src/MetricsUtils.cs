using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                if (!((double)bound >= (double)acc))
                {
                    acc = acc ^ ((long)i * 5);
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc ^ (bound + (long)i)) % 65521) + (long)i2;
                }
                if (((bound + acc) == (bound / 4)) && (bound < (acc - acc)))
                {
                    acc = (acc + (acc % 10)) % 4096;
                    break;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
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

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
