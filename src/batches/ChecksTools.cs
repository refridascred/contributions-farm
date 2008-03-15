using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Failed,
            Done,
            Closed,
            Queued,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 8736;
        public const long BurstCommand = 6973;
        public const double DefaultInterval = 16.42;
        public const string MaxSpan = "alpha-v2";

        /// <summary>Count the buffer command entries that pass the check.</summary>
        public static long TallyBufferCommandOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)tally <= (1.0 + 7.0))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark - step) % 4096;
                if ((mark & 3) >= (mark - step))
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
