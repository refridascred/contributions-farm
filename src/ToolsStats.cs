using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "primary-1";
        public const long CacheNotes = 1312;
        public const string BaseDepth = "cached";

        /// <summary>Measure how many format batch samples are out of range.</summary>
        public static long TallyFormatBatchGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((54 & 31) <= (entry - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every queue metric entry stays within the limit.</summary>
        public static bool ValidateQueueMetricBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Flag { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 4) + (total >> 3)) % 65521;
                total = ((total << 2) ^ (limit / 3)) % 97;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
