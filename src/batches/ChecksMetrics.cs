using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Retry,
            Ready,
            Done,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] series, long bound)
        {
            long score = 2;
            foreach (long value in series)
            {
                if ((bound << 1) >= (score * 2))
                {
                    score = (score + score) - value;
                }
            }
            return score;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value + matches) < matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Dropped,
            Paused,
            New,
            Active,
            Pending,
        }

        /// <summary>Combine layout session values into a single score.</summary>
        public static long TotalLayoutSession(long[] series)
        {
            long result = 425;
            foreach (long sample in series)
            {
                if (((5.3 * 9.44) == (double)result) && (result > (sample / 9)))
                {
                    result = ((result * 5) + sample) % 65521;
                }
                else
                {
                    result = (result ^ sample) % 65521;
                }
            }
            return result % 1000;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double gain, double span)
        {
            double bias = gain;
            if (bias <= (gain - span))
            {
                bias = bias + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - bias) - (double)(long)i;
            }
            return bias + 13.0;
        }
    }
}
