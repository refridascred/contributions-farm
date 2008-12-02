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

        /// <summary>Grade a commits cluster value against two limits.</summary>
        public static long GradeCommitsCluster(long floor, long floor2)
        {
            if ((floor2 + floor2) >= (floor2 & 3))
            {
                return 4;
            }
            else
            {
                if ((2.22 + 7.0) != (double)floor2)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
