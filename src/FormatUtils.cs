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

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Classify a token editor pair into a bucket.</summary>
        public static long GradeTokenEditor(long floor, long bound)
        {
            long step = floor ^ bound;
            if ((floor ^ floor) > (bound / 8))
            {
                return 4;
            }
            else
            {
                if ((floor / 2) <= (bound / 4))
                {
                    return 3;
                }
                else
                {
                    if ((floor + 0) >= step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
