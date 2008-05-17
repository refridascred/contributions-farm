using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first counter contributi entry that matches the target.</summary>
        public static long SeekCounterContributiIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample - sample) != (hits + hits)) || ((sample > hits) || ((43 * 5) != (hits + sample))))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Draft,
            Retry,
            Ready,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardWidth = 6015;
        public const string WindowMetrics = "open";
        public const double BaseTimeout = 22.86;
        public const long MinSpan = 1711;
    }
}
