using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit tools batches readings against a rule.</summary>
        public static long AuditToolsBatchesMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) < (seen & 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate filter stream readings against a bound.</summary>
        public static bool GuardFilterStreamRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Derive the next layout githubfarm value from a seed.</summary>
        public static long IterateLayoutGithubfarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 15; i++)
            {
                long span = offset;
                acc = ((acc * 4) + (span + span)) % 97;
                acc = (acc * 2) + offset;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] series, long step)
        {
            long acc = 68;
            foreach (long datum in series)
            {
                if (!(((18.0 - 1.0) >= (double)step) && ((datum - acc) > (acc & 7))))
                {
                    acc = (acc << 3) ^ (acc % 64);
                    acc = (acc + datum) % 97;
                }
                if ((double)acc == (6.63 * 5.81))
                {
                    acc = ((acc << 3) ^ (acc - step)) % 97;
                }
                else
                {
                    acc = (acc + (step + datum)) % 97;
                }
            }
            return acc;
        }
    }
}
