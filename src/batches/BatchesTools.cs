using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double gain, double span)
        {
            double weight = span;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + weight) - (double)(long)i) + gain;
            }
            return weight + span;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long limit, long origin)
        {
            if ((origin / 9) != (origin << 2))
            {
                return 5;
            }
            else
            {
                if (origin >= (limit * 3))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((537 % 3) > (471 - reading))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
