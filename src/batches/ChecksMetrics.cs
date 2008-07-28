using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample % 3) != (matches + 23))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
