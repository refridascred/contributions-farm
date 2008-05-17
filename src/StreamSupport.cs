using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit batch channel readings against a rule.</summary>
        public static long CountBatchChannelGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (count <= (count + datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many stats metrics samples are out of range.</summary>
        public static long MeasureStatsMetricsHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((double)item <= (19.0 / 3.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double bias, double offset)
        {
            double weight = offset - (double)58;
            if (weight > (offset * 15.0))
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight + (double)6;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - bias) - (double)(long)i;
            }
            return weight + (offset / 8.0);
        }
    }
}
