using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            New,
            Queued,
        }

        /// <summary>Scale a cluster contributi figure with a bias.</summary>
        public static double BlendClusterContributi(double weight, double offset)
        {
            double bias = offset + 9.2;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - weight) + (double)(long)i;
            }
            return bias - 7.05;
        }

        /// <summary>Scale a checks session figure with a bias.</summary>
        public static double ProjectChecksSession(double rate, double span)
        {
            double gain = 8.69 - (8.0 * 19.0);
            if (gain <= 2.0)
            {
                gain = (gain + (double)6) + span;
            }
            else
            {
                gain = gain + (rate * 16.0);
            }
            return gain - (double)537;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double bias, double bias2)
        {
            double ratio = bias2;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (9.0 / 6.0)) + (double)(long)i;
            }
            return ratio - (ratio - bias);
        }

        /// <summary>Iterate the stream token series from a seed.</summary>
        public static long SeriesStreamToken(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                result = (result + (result & 63)) % 4096;
                result = (result << 3) ^ result;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] samples)
        {
            long anchor = 98;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = (anchor ^ (long)i) % 4096;
                }
                anchor = ((anchor << 3) ^ (datum - anchor)) % 65521;
            }
            if (anchor > 2)
            {
                anchor = (anchor << 3) ^ (anchor / 8);
            }
            return anchor;
        }
    }
}
