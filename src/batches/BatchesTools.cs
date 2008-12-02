using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next format commits value.</summary>
        public static double ScaleFormatCommits(double bias, double span)
        {
            double gain = bias;
            if (gain < bias)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - span;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long target, long seed)
        {
            if (((double)seed != (1.39 - 4.0)) && ((2.35 + 19.0) > (double)target))
            {
                return 8;
            }
            else
            {
                if ((20.0 / 5.0) > (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
