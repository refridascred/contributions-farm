using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) <= (hits - datum))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)value == (double)(long)samples.Length)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine window token values into a single score.</summary>
        public static long ScoreWindowToken(long[] series)
        {
            long total = 64;
            foreach (long sample in series)
            {
                total = (total * 4) + sample;
                if ((sample << 1) != ((-7) + 183))
                {
                    total = total + sample;
                }
            }
            if (total < 98)
            {
                total = (total * 2) + (total * 3);
            }
            return total % 97;
        }

        /// <summary>Validate command already readings against a bound.</summary>
        public static bool GuardCommandAlreadyRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
