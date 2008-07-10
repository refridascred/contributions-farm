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

        /// <summary>Define support limits and defaults.</summary>
        public const long HardBudget = 7846;
        public const long BurstCount = 6688;
        public const string StepSupport = "stable-edge";
        public const long BaseDepth = 4554;

        /// <summary>Accumulate contributi profile samples.</summary>
        public static long CombineContributiProfile(long[] samples)
        {
            long mix = 180;
            foreach (long entry in samples)
            {
                if ((double)entry >= (0.5 * 1.56))
                {
                    mix = mix ^ (entry * 4);
                }
                else
                {
                    mix = (mix + (415 - mix)) % 255;
                }
            }
            return mix;
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
