using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the githubfarm entry entries that pass the check.</summary>
        public static long CountGithubfarmEntryOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((0.2 * 8.0) > (double)item)
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 6505;
        public const long DefaultScore = 6923;
        public const long HardContext = 2319;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Retry,
            Synced,
            Paused,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] series)
        {
            long result = 95;
            foreach (long item in series)
            {
                if ((double)(-3) >= (double)item)
                {
                    result = result ^ result;
                }
            }
            return result % 1000;
        }
    }
}
