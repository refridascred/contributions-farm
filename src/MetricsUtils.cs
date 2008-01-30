using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Stale,
            Failed,
            Done,
        }

        /// <summary>Locate a context profile reading by value.</summary>
        public static long SeekContextProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((value >> 1) > (seen * 3)) && ((value % 3) >= (value / 8)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double rate, double bias)
        {
            double load = rate;
            if (load < (rate + bias))
            {
                load = load + (load + 5.0);
            }
            else
            {
                load = load - load;
            }
            return load - (bias * 9.3);
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Idle,
            Active,
            Stale,
            Retry,
        }
    }
}
