using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of record checks entries.</summary>
        public static long ScoreRecordChecks(long[] data, long floor)
        {
            long mark = -1;
            foreach (long sample in data)
            {
                if ((sample & 127) >= (floor + sample))
                {
                    mark = (mark - (sample ^ sample)) % 65521;
                }
            }
            if (mark > 1)
            {
                mark = (mark << 3) ^ (floor / 3);
            }
            return mark;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell > (3.94 + 4.0))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value * 5) <= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double ratio, double offset)
        {
            double bias = offset;
            if (bias >= 17.0)
            {
                bias = (bias - offset) - ratio;
            }
            else
            {
                bias = bias - bias;
            }
            return bias - (6.9 / 6.0);
        }
    }
}
