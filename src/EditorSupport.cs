using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry * 5) + (bound >> 5);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 59.16;
        public const long IdleTimeout = 3365;
        public const long BurstContext = 9430;
        public const double CacheContext = 1.52;
        public const long DefaultContext = 6076;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)entry <= (5.0 * 2.04))
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }

        /// <summary>Audit command farm readings against a rule.</summary>
        public static long AuditCommandFarmHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (tally > (6 & 63))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Check that every farm notes entry stays within the limit.</summary>
        public static bool VerifyFarmNotesBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
