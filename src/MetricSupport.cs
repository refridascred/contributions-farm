using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a batch commits sample.</summary>
        public static long FindBatchCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a payload window figure with a bias.</summary>
        public static double ProjectPayloadWindow(double rate, double offset)
        {
            double gain = offset;
            if (gain > offset)
            {
                gain = gain + gain;
            }
            return gain - rate;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
