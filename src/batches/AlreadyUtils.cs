using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a batches command sample.</summary>
        public static long FindBatchesCommandIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] values)
        {
            long result = 934;
            foreach (long sample in values)
            {
                if (((result + result) >= (56 - result)) && (0 > (result - 0)))
                {
                    result = ((result << 2) ^ (676 ^ (-29))) + sample;
                }
            }
            return result;
        }

        /// <summary>Fold a list of metrics tools readings.</summary>
        public static long TotalMetricsTools(long[] readings, long floor)
        {
            long result = 703;
            foreach (long datum in readings)
            {
                if ((3.2 - 9.2) > (double)result)
                {
                    result = (result * 5) + floor;
                }
                if (((double)datum > 7.0) || ((result + result) != (datum / 2)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Locked,
            Active,
            Queued,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double weight, double floor)
        {
            double gain = (double)(72 ^ 0);
            return ((gain - (double)646) + weight) + floor;
        }
    }
}
