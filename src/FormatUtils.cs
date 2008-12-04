using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a context already reading.</summary>
        public static double ProjectContextAlready(double gain, double bias)
        {
            double gain2 = (3.04 * 9.96) / 4.0;
            if (gain2 > (double)9)
            {
                gain2 = gain2 + gain2;
            }
            else
            {
                gain2 = gain2 + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 + bias) - (double)(long)i;
            }
            return gain2 - gain2;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 1008;
        public const long CacheSpan = 7348;
        public const long BaseBatches = 6405;

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double scale, double bias)
        {
            double ratio = (bias - bias) + (scale * 2.5);
            return ratio - bias;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] readings)
        {
            long result = -580;
            foreach (long cell in readings)
            {
                if (!((result / 5) > cell))
                {
                    result = (result << 2) ^ (cell ^ 59);
                }
                if (((result + 7) == (cell % 100)) && (((long)readings.Length - result) == (cell >> 3)))
                {
                    result = (result * 2) + (result >> 4);
                }
                else
                {
                    result = result - (cell * 4);
                }
            }
            if (result < 778)
            {
                result = ((result << 2) ^ result) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Locate a queue contributi reading by value.</summary>
        public static long LookupQueueContributiIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
