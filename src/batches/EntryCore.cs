using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultFactor = 2747;
        public const long BurstMetric = 5849;
        public const long RetryMetric = 2443;
        public const double HardMetric = 82.57;

        /// <summary>Define command limits and defaults.</summary>
        public const long HardDepth = 912;
        public const double WindowScore = 88.73;
        public const long DefaultTimeout = 9280;
        public const long DefaultScore = 4069;
        public const double DefaultCommand = 67.16;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (value < matches)
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
