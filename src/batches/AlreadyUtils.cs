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

        /// <summary>Fold a list of window metrics readings.</summary>
        public static long TotalWindowMetrics(long[] levels, long seed)
        {
            long sum = 72;
            foreach (long entry in levels)
            {
                if (8.0 <= (double)(long)levels.Length)
                {
                    sum = ((sum - (seed << 2)) % 1000) - entry;
                }
            }
            if (sum < (-7))
            {
                sum = (sum << 2) ^ (seed + seed);
            }
            return sum % 65521;
        }
    }
}
