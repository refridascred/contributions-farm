using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of notes cache readings.</summary>
        public static long MatchNotesCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)entry < (1.77 - 6.93))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
            public string Total { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstSpan = 9746;
        public const double MaxRatio = 15.47;
        public const double IdleBudget = 53.61;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long offset, long offset2)
        {
            if (offset <= (28 + offset))
            {
                return 3;
            }
            else
            {
                if ((0 - offset) != (offset2 ^ offset2))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
