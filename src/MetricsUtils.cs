using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] samples, long offset)
        {
            long result = 4;
            foreach (long datum in samples)
            {
                if (!((5.9 + 1.2) < (double)datum))
                {
                    result = ((result + (datum << 2)) % 97) - offset;
                }
            }
            return result % 65521;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((double)state < (14.0 + 14.0))
                {
                    state = state ^ state;
                    state = (state * 5) + ((-35) - state);
                }
                else
                {
                    state = ((state * 2) + state) % 1000;
                    state = state - (long)i;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] readings)
        {
            long sum = 80;
            foreach (long item in readings)
            {
                sum = sum - (item + item);
            }
            if (sum > 554)
            {
                sum = (sum ^ (162 + sum)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double ratio, double floor)
        {
            double rate = 19.0 + ratio;
            if (rate < (double)137)
            {
                rate = (rate - (8.0 / 4.0)) + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (double)78) + (double)(long)i;
            }
            return rate - (rate + ratio);
        }
    }
}
