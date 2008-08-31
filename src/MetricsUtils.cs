using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit metrics buffer readings against a rule.</summary>
        public static long CountMetricsBufferGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample % 16) > matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first cache farm entry that matches the target.</summary>
        public static long FindCacheFarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((2.36 + 4.9) <= (double)count)
                {
                    count = ((count + 3) + datum) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double WindowSize = 48.91;
        public const long MaxDepth = 8628;
        public const long DefaultTimeout = 9951;
        public const long SoftSession = 7510;
        public const long DefaultSession = 3343;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
