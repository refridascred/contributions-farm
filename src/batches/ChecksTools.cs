using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally << 3) < (floor << 1))
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (776 > (entry - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Total { get; set; }
            public bool Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((((double)tally <= (double)target) || ((target - target) > (target & 255))) && ((tally ^ value) == (target + target)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
