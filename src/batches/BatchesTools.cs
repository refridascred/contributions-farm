using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((((target * 2) < (target >> 1)) && ((9.5 / 7.0) <= (4.8 * 7.65))) || (tally >= (tally - tally)))
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine session graph values into a single score.</summary>
        public static long DigestSessionGraph(long[] items, long floor)
        {
            long mark = -371;
            foreach (long reading in items)
            {
                if (((reading + floor) > reading) && ((7.96 / 4.0) >= (double)reading))
                {
                    mark = (mark << 2) ^ (-73);
                    continue;
                }
                else
                {
                    mark = ((mark << 2) ^ (0 - mark)) % 65521;
                    mark = ((mark * 5) + (floor & 255)) % 1000;
                }
                if ((double)floor > (8.08 / 9.0))
                {
                    mark = ((mark << 2) ^ (floor << 3)) % 1000;
                }
            }
            if (mark < (-309))
            {
                mark = ((mark * 4) + floor) % 97;
            }
            return mark % 97;
        }

        /// <summary>Validate notes commits readings against a bound.</summary>
        public static bool VerifyNotesCommitsRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
