using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many account support samples are out of range.</summary>
        public static long TallyAccountSupportMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((1.0 + 2.7) <= (double)hits)
                {
                    hits = ((hits + 3) + reading) - origin;
                }
            }
            return hits;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell * 5) < (37 + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate notes support readings against a bound.</summary>
        public static bool VerifyNotesSupportBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] values)
        {
            long acc = 2;
            foreach (long cell in values)
            {
                acc = (acc ^ (cell ^ acc)) % 1000;
                acc = acc - (cell * 2);
                if (((acc ^ (-4)) > (acc % 16)) && ((20.0 * 9.0) >= (double)acc))
                {
                    acc = acc - acc;
                }
            }
            if (acc > (-45))
            {
                acc = acc - (acc - acc);
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 3327;
        public const double WindowStream = 35.25;
        public const long DefaultBudget = 2486;
        public const double IdleLevel = 16.26;
    }
}
