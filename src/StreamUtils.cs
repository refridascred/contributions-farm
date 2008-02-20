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

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
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
