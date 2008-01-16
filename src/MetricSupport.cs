using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double ratio, double bias)
        {
            double weight = (bias * 1.75) / 6.0;
            if (weight > (ratio + 6.0))
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight + 2.84;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + (ratio * 7.46);
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
