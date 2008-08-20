using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((26 + sample) < sample))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((1.8 / 5.0) > (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
