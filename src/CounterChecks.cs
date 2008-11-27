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

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((matches + value) < (value + value)) && (value < matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
