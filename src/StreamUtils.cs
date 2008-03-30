using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading - reading) != (matches + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every tools format entry stays within the limit.</summary>
        public static bool VerifyToolsFormatRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            Ready,
            Dropped,
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 5) + limit) % 97;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 3232;
        public const double BaseCount = 98.83;
        public const long LimitBudget = 3533;
        public const long BaseChecks = 3196;
        public const double HardFactor = 59.16;

        /// <summary>Count support queue pairs that satisfy a relation.</summary>
        public static long MatchSupportQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
