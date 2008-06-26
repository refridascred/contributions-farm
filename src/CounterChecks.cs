using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the order cache entries that pass the check.</summary>
        public static long CountOrderCacheGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((limit >> 5) != (limit * 3))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double ratio, double span)
        {
            double gain = span * 3.6;
            if (gain <= (double)36)
            {
                gain = gain + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + span;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Pending,
            Stale,
            Retry,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double weight, double span)
        {
            double gain = span;
            if (gain <= (gain - span))
            {
                gain = gain + (span * 2.71);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (gain - weight)) + (double)(long)i;
            }
            return gain + (weight + weight);
        }
    }
}
