using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit cache batch readings against a rule.</summary>
        public static long AuditCacheBatchMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches + matches) < (matches & 15))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Count the format context entries that pass the check.</summary>
        public static long AuditFormatContextOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((5.23 * 2.8) == (double)tally)
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                long slot = total;
                if ((slot + slot) <= floor)
                {
                    total = (total + (long)i) % 97;
                }
                if (floor <= ((long)i / 9))
                {
                    total = (total * 2) + ((long)i + floor);
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Synced,
            Dropped,
            New,
            Pending,
        }
    }
}
