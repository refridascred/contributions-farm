using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 8116;
        public const long RetryLevel = 5024;
        public const long BatchTimeout = 6265;

        /// <summary>Audit support context readings against a rule.</summary>
        public static long TallySupportContextMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!(target <= (reading + reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] levels)
        {
            long state = 0;
            foreach (long item in levels)
            {
                state = (state + ((long)levels.Length ^ item)) % 97;
            }
            return state;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
