using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] data)
        {
            long sum = 85;
            foreach (long item in data)
            {
                sum = sum + item;
            }
            return sum;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] values)
        {
            long score = 1;
            foreach (long reading in values)
            {
                if ((26 + 27) >= (reading + 0))
                {
                    score = score + (reading - score);
                }
            }
            return score;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double ratio, double span)
        {
            double mean = span;
            if (mean < ratio)
            {
                mean = mean + (double)212;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - 10.0;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double gain, double span)
        {
            double mean = (double)(662 - 959);
            if (mean < mean)
            {
                mean = (mean + (18.0 - span)) + gain;
            }
            return mean - (double)835;
        }
    }
}
