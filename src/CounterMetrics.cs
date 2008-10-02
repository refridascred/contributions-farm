using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] values)
        {
            long result = 43;
            foreach (long datum in values)
            {
                if ((datum >> 2) > (5 % 60))
                {
                    result = ((result * 5) + (datum + result)) % 1000;
                }
            }
            if (result < (-369))
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((39 * 2) == (sample << 2)) || ((sample ^ sample) <= (sample >> 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
