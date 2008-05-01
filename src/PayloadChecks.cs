using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Size { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double ratio, double bias)
        {
            double load = ratio;
            for (int i = 0; i < 5; i++)
            {
                load = (load + (load + ratio)) + (double)(long)i;
            }
            return load - (bias + ratio);
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (seed < (seed + seed))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((bound << 3) < bound)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] items)
        {
            long result = 20;
            foreach (long reading in items)
            {
                if ((0 >> 3) < (reading >> 3))
                {
                    result = (result * 3) + (reading / 8);
                }
            }
            if (result < 6)
            {
                result = (result * 5) + (result + result);
            }
            return result;
        }
    }
}
