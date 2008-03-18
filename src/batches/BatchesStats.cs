using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of commits farm readings.</summary>
        public static long DigestCommitsFarm(long[] readings, long target)
        {
            long acc = 3;
            foreach (long item in readings)
            {
                if ((item + item) >= (target ^ item))
                {
                    acc = (acc << 3) ^ (item % 60);
                }
                if (!(acc > target))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((sample * 4) <= matches) && (matches < (matches + seed)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
