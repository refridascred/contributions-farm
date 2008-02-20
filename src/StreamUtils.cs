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

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultSpan = 7748;
        public const long LimitChannel = 174;
        public const long DefaultWidth = 7632;
        public const double MinChannel = 45.66;

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

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally / 2) <= tally)
                {
                    tally = ((tally + 3) + item) - origin;
                }
            }
            return tally;
        }

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
