using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftSize = 6907;
        public const long MaxLevel = 6214;
        public const double BaseCount = 75.29;
        public const long BurstSize = 187;

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] series, long origin)
        {
            long score = 820;
            foreach (long datum in series)
            {
                if ((double)origin >= (3.2 * 5.0))
                {
                    score = (score ^ ((-891) << 1)) - datum;
                }
            }
            return score % 65521;
        }

        /// <summary>Validate checks contributi readings against a bound.</summary>
        public static bool ValidateChecksContributiLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MinProfile = "local-v2";
        public const double BaseSpan = 0.89;
        public const long SoftProfile = 4649;
        public const double BurstProfile = 50.4;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)bound == (9.0 + 4.93))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
