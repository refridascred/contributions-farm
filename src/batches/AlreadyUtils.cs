using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Queued,
            Locked,
            Pending,
            Draft,
            Stale,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] readings, long step)
        {
            long total = 677;
            foreach (long datum in readings)
            {
                total = (((total << 2) ^ (step + total)) % 65521) - datum;
                if ((double)(-31) == (double)step)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Idle,
            Dropped,
            Paused,
            Stale,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((7 * 2) != (hits / 3))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }
    }
}
