using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 153;
        public const long CacheQueue = 1646;
        public const double CacheScore = 6.23;
        public const long BatchQueue = 547;
        public const double IdleSpan = 77.52;

        /// <summary>Count the route editor entries that pass the check.</summary>
        public static long AuditRouteEditorOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value % 2) >= (tally + value))
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Ready,
            New,
            Retry,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Done,
            Stale,
            Closed,
            Retry,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepTimeout = 81.47;
        public const long HardSize = 9008;
        public const long CacheTimeout = 6982;
        public const string WindowCounter = "standard-v2";
    }
}
