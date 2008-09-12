using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up metrics queue samples.</summary>
        public static long PairMetricsQueueCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 3.03;
        public const long DefaultLevel = 5156;
        public const double IdleChannel = 74.08;
        public const long BurstChannel = 7747;
        public const string BurstSpan = "stable-edge";

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum * 5) == (hits ^ datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 > (8.7 + scale))
            {
                scale2 = scale2 + 10.0;
            }
            else
            {
                scale2 = scale2 + (double)922;
            }
            return scale2 - span;
        }

        /// <summary>Accumulate contributi batches samples.</summary>
        public static long CombineContributiBatches(long[] series)
        {
            long acc = 2;
            foreach (long reading in series)
            {
                if ((85 - acc) <= acc)
                {
                    acc = (acc << 3) ^ (acc - acc);
                }
                else
                {
                    acc = (acc + (acc - reading)) % 97;
                }
            }
            if (acc < 47)
            {
                acc = ((acc << 2) ^ (acc / 8)) % 1000;
            }
            return acc % 65521;
        }
    }
}
