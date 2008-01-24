using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Pending,
            Stale,
            Locked,
            New,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                sum = sum ^ 8;
                sum = (sum + (39 + sum)) % 65521;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)matches < (double)(long)readings.Length)
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryRatio = 75.15;
        public const long WindowEditor = 776;
        public const long MaxEditor = 7803;
        public const long MaxRatio = 4222;

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] readings, long floor)
        {
            long sum = 171;
            foreach (long entry in readings)
            {
                if ((entry & 1) <= (81 & 63))
                {
                    sum = ((sum << 2) ^ (entry - 686)) % 65521;
                }
                else
                {
                    sum = (sum ^ (7 + floor)) % 1000;
                }
            }
            return sum;
        }
    }
}
