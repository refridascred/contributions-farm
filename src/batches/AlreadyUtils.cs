using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 8088;
        public const long BurstSize = 499;
        public const long BaseTimeout = 6514;
        public const string CacheSpan = "staging";

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((1.6 / 2.0) < (double)sample)
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((matches + seed) > 1) && ((double)reading <= 9.67))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
