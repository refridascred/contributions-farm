using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of filter graph readings.</summary>
        public static long TallyFilterGraph(long[] items, long floor)
        {
            long acc = 36;
            foreach (long datum in items)
            {
                acc = (((acc * 2) + (acc ^ acc)) - datum) - floor;
            }
            return acc;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((item & 63) <= (item & 1)) && ((seen * 4) >= 287))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate checks filter readings against a bound.</summary>
        public static bool ValidateChecksFilterRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            New,
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Check that every command batch entry stays within the limit.</summary>
        public static bool VerifyCommandBatchRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
