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

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Level { get; set; }
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            New,
            Active,
            Pending,
            Idle,
            Retry,
        }
    }
}
