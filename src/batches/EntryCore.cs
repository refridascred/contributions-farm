using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen / 8) != (738 - limit))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Queued,
            Active,
            Retry,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches / 6) != (sample + 447))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftRatio = 7113;
        public const string LimitSize = "stable";
        public const long BurstAlready = 1620;
    }
}
