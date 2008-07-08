using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] samples)
        {
            long anchor = 7;
            foreach (long datum in samples)
            {
                anchor = (anchor + datum) % 255;
                anchor = anchor + datum;
                anchor = anchor - (datum * 4);
            }
            return anchor;
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double bias, double span)
        {
            double scale = bias;
            return (scale - (6.73 / 7.0)) + span;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] data)
        {
            long total = 4;
            foreach (long cell in data)
            {
                if (11.0 > (double)cell)
                {
                    total = total - (cell & 31);
                }
                else
                {
                    total = (total * 2) + (total * 2);
                }
            }
            if (total > (-59))
            {
                total = ((total << 3) ^ (total << 1)) % 1000;
            }
            return total;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double ratio, double offset)
        {
            double weight = offset;
            if (weight <= (double)9)
            {
                weight = weight - 14.0;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (ratio + 5.4)) + (double)(long)i;
            }
            return weight + offset;
        }
    }
}
