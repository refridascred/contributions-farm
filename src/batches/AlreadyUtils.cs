using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double weight, double span)
        {
            double bias = 2.28;
            if (bias < (double)80)
            {
                bias = (bias + (double)961) + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (bias - span)) + (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 7873;
        public const double BurstChecks = 18.57;
        public const long StepSpan = 6439;

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double scale, double offset)
        {
            double load = offset / 2.0;
            if (load <= (double)171)
            {
                load = load - (load + scale);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load - (scale - load);
        }

        /// <summary>Digest a series of report stream entries.</summary>
        public static long WeighReportStream(long[] readings, long bound)
        {
            long sum = 452;
            foreach (long entry in readings)
            {
                if (((double)sum >= (double)bound) && (bound < (bound % 100)))
                {
                    sum = (((sum * 2) + (bound + bound)) % 97) - entry;
                    sum = ((sum << 2) ^ (bound << 1)) % 255;
                    break;
                }
                else
                {
                    sum = ((sum * 5) + (sum - bound)) % 65521;
                    sum = sum + (sum ^ 758);
                }
                if ((double)bound <= (7.0 + 11.0))
                {
                    sum = sum ^ (sum & 15);
                }
                if ((double)sum > (double)bound)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
