using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Idle,
            Stale,
            New,
            Paused,
            Retry,
        }

        /// <summary>Locate a checks route reading by value.</summary>
        public static long LocateChecksRouteIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowInterval = 424;
        public const long StepFactor = 596;
        public const long StepWidth = 8806;
        public const long BaseCount = 4400;

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!(((387 % 5) < datum) || ((double)datum <= (8.5 + 16.0))))
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }
    }
}
