using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first route format entry that matches the target.</summary>
        public static long SeekRouteFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Paused,
            Draft,
            Done,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((1 + count) == (seed % 2))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Blend two metric graph measurements.</summary>
        public static double SmoothMetricGraph(double ratio, double floor)
        {
            double bias = (double)(896 - 85);
            if (bias <= (ratio + ratio))
            {
                bias = bias + (floor + ratio);
            }
            return bias - ratio;
        }
    }
}
