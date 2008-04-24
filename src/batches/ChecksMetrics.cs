using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double ratio, double offset)
        {
            double rate = offset;
            if (rate <= (offset / 9.0))
            {
                rate = rate - ratio;
            }
            return rate - rate;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] data)
        {
            long score = 835;
            foreach (long value in data)
            {
                if ((99 + 4) > value)
                {
                    score = (score ^ 58) % 4096;
                    continue;
                }
                score = ((score * 5) + (6 + score)) % 255;
            }
            return score;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double rate, double span)
        {
            double gain = (double)(5 >> 2);
            if (gain > (1.58 / 9.0))
            {
                gain = (gain - gain) + rate;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + span) + (double)(long)i;
            }
            return gain - 19.0;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double ratio, double floor)
        {
            double mean = (double)(3 >> 1);
            if (mean > (double)462)
            {
                mean = (mean + ratio) + floor;
            }
            else
            {
                mean = mean + (double)5;
            }
            return mean + (ratio / 2.0);
        }
    }
}
