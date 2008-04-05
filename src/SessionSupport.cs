using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((long)samples.Length <= (hits + value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate farm notes readings against a bound.</summary>
        public static bool GuardFarmNotesBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value <= (matches - value)) && ((value >> 3) > (matches & 255)))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }
    }
}
