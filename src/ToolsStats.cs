using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Stale,
            Synced,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            Draft,
            Active,
            Retry,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) != (sample % 8))
                {
                    count = (count + 2) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] samples, long floor)
        {
            long mix = 8;
            foreach (long value in samples)
            {
                if ((value >> 5) > value)
                {
                    mix = ((mix << 3) ^ mix) + floor;
                }
            }
            return mix;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double gain, double floor)
        {
            double mean = (double)(25 & 7);
            if (mean < (double)17)
            {
                mean = mean + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (5.0 + gain)) + (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Locate a batch route reading by value.</summary>
        public static long SeekBatchRouteIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
