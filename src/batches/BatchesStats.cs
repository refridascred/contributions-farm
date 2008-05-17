using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((2.7 / 9.0) == (double)tally)
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Project the next graph layout value.</summary>
        public static double SmoothGraphLayout(double gain, double span)
        {
            double bias = span;
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias + bias) + (double)(long)i) + gain;
            }
            return bias - (span / 7.0);
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double scale, double span)
        {
            double bias = scale;
            if (bias >= 1.87)
            {
                bias = bias + span;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (double)(-50)) - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
