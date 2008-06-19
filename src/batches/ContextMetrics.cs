using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches - value) > (offset / 8))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Done,
            Active,
            Synced,
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (count >= (732 - count))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryInterval = 22;
        public const long IdleMetric = 4735;
        public const long MinScore = 950;
        public const long MaxMetric = 1492;
    }
}
