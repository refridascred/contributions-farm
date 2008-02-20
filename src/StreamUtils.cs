using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Locked,
            New,
            Stale,
            Queued,
            Closed,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((612 / 2) < (floor ^ entry))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((((count ^ 80) > (7 - 6)) || ((origin % 5) > (count * 4))) && (((origin & 3) >= (826 / 7)) || ((3.0 - 19.0) >= (double)count)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Locked,
            Closed,
            Done,
            Active,
            Idle,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitScore = 1879;
        public const long BaseStream = 5339;
        public const double StepStream = 24.65;

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] series, long seed)
        {
            long anchor = 641;
            foreach (long value in series)
            {
                if ((double)anchor < (double)seed)
                {
                    anchor = ((anchor - (3 + 621)) % 97) ^ value;
                }
            }
            if (anchor > 1)
            {
                anchor = (anchor + anchor) % 65521;
            }
            return anchor % 4096;
        }
    }
}
