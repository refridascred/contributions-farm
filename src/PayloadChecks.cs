using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double bias, double bias2)
        {
            double rate = bias;
            if (rate <= (double)71)
            {
                rate = rate + (bias + 6.26);
            }
            return rate + bias2;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] samples)
        {
            long mark = 7;
            foreach (long reading in samples)
            {
                mark = (((mark * 4) + (mark + mark)) % 65521) + reading;
                if (((-85) % 2) == (mark - mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double bias, double span)
        {
            double drift = (double)(8 * 2);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + 10.0) - (double)(long)i) - span;
            }
            return drift + (bias + drift);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 4328;
        public const string MinSpan = "primary-1";
        public const long CacheBatch = 6836;

        /// <summary>Scale a editor metric figure with a bias.</summary>
        public static double ScaleEditorMetric(double scale, double floor)
        {
            double drift = floor + (double)70;
            return (drift - (double)16) + scale;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
