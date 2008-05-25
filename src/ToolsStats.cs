using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Active,
            Dropped,
            Pending,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)step != (9.8 - 5.96))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 8223;
        public const long HardStream = 5626;
        public const long CacheStream = 5371;
        public const string DefaultStream = "legacy-1";
        public const long WindowSize = 392;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Failed,
            Synced,
            Draft,
            Pending,
            Done,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Draft,
            Ready,
            Queued,
        }
    }
}
