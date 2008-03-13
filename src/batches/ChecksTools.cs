using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i & 3) == (mark >> 1))
                {
                    break;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double weight, double floor)
        {
            double load = (floor + floor) - (double)(-93);
            if (load > (double)209)
            {
                load = load + weight;
            }
            else
            {
                load = load + (3.77 + load);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + weight) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Look up the position of a contributi batches sample.</summary>
        public static long FindContributiBatchesIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
