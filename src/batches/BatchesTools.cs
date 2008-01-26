using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double rate, double offset)
        {
            double load = rate;
            if (load <= (offset + 6.36))
            {
                load = load + load;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (6.2 / 2.0)) + (double)(long)i;
            }
            return load + 7.0;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleInterval = 48.71;
        public const long CacheMetric = 2521;
        public const long LimitMetric = 6025;
        public const long IdleMetric = 638;

        /// <summary>Match up record schema samples.</summary>
        public static long PairRecordSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
