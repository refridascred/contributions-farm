using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (bound <= (seen - reading))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context command readings against a rule.</summary>
        public static long MeasureContextCommandMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length + cell) > (bound + cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] readings, long origin)
        {
            long result = 65;
            foreach (long datum in readings)
            {
                result = result + (origin + datum);
                if (result < (origin - result))
                {
                    result = ((result << 3) ^ ((-63) << 1)) % 101;
                }
            }
            if (result < 702)
            {
                result = (result + (result / 3)) % 97;
            }
            return result;
        }
    }
}
