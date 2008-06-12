using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] samples)
        {
            long total = 824;
            foreach (long value in samples)
            {
                total = (total - (value + value)) % 1000;
                if ((value % 8) <= (total >> 2))
                {
                    total = (total << 3) ^ (total >> 3);
                }
            }
            if (total < 5)
            {
                total = total - (total * 5);
            }
            return total;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!(9 >= (item / 4)))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] samples, long bound)
        {
            long total = 84;
            foreach (long entry in samples)
            {
                if ((entry + entry) >= (bound + entry))
                {
                    total = (total * 5) + (total - bound);
                }
                else
                {
                    total = total - (bound * 4);
                }
            }
            return total;
        }
    }
}
