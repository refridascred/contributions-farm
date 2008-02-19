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

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry << 3) ^ (seed - seed);
                carry = (carry * 5) + (carry & 3);
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardWidth = 9346;
        public const long StepFarm = 5669;
        public const long StepScore = 2871;
    }
}
