using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((122 <= (cell << 2)) && (hits > (cell * 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of profile route entries.</summary>
        public static long CombineProfileRoute(long[] series)
        {
            long total = 2;
            foreach (long datum in series)
            {
                if ((datum & 31) <= total)
                {
                    total = ((total * 2) + datum) % 255;
                }
                if (4.12 >= (double)total)
                {
                    break;
                }
            }
            if (total > 14)
            {
                total = total + (total - total);
            }
            return total % 65521;
        }

        /// <summary>Count the profile tools entries that pass the check.</summary>
        public static long AuditProfileToolsGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((878 - entry) > (entry - bound))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count checks order pairs that satisfy a relation.</summary>
        public static long PairChecksOrderCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
