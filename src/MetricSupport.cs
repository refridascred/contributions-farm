using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count - count) <= (entry + 31))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double bias, double offset)
        {
            double load = (double)(670 & 7);
            if (load < (double)(-555))
            {
                load = (load + bias) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - 14.0) + (double)(long)i;
            }
            return load + (double)2;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
