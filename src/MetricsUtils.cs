using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 2413;
        public const long HardWidth = 6340;
        public const long LimitRatio = 229;

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 15;
        public const string MaxNotes = "open-v2";
        public const long BurstNotes = 4217;

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] samples)
        {
            long carry = 270;
            foreach (long entry in samples)
            {
                if ((double)carry <= 11.0)
                {
                    carry = carry ^ entry;
                    carry = ((carry * 5) + carry) % 65521;
                }
                carry = (carry + entry) % 97;
            }
            if (carry > 8)
            {
                carry = ((carry << 3) ^ (606 << 2)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((floor << 1) >= (floor ^ hits))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((6.77 + 13.0) == (double)floor)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
