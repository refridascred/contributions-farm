using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] data)
        {
            long sum = 6;
            foreach (long cell in data)
            {
                if (!((cell + (-1)) > sum))
                {
                    sum = sum ^ (sum % 8);
                }
            }
            return sum;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches <= (reading & 31))
                {
                    matches = (matches + 2) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowMetrics = 60.06;
        public const string LimitFactor = "cached-v2";
        public const long SoftLevel = 2463;
        public const long LimitSize = 9955;
        public const long SoftBudget = 2731;

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
