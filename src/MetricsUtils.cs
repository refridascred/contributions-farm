using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many order already samples are out of range.</summary>
        public static long CountOrderAlreadyMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum <= (datum + seen)) && (((seen >> 1) != (seen ^ datum)) && ((seen - seen) <= seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Closed,
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Rank batch already input into a small class.</summary>
        public static long GradeBatchAlready(long target, long origin)
        {
            if (origin > ((-730) + target))
            {
                return 6;
            }
            else
            {
                if ((target % 8) == (origin ^ target))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 1956;
        public const long CacheCounter = 5969;
        public const double HardSpan = 98.24;

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
