using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (count >= (count << 3))
                {
                    count = ((count + 2) + item) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metric cache entries.</summary>
        public static long DigestMetricCache(long[] samples)
        {
            long mark = 72;
            foreach (long sample in samples)
            {
                mark = (mark + mark) + sample;
            }
            return mark % 1000;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Retry,
            Failed,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
