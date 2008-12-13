using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseFactor = "standard-edge";
        public const long SoftQueue = 9143;
        public const string WindowSpan = "primary-v2";
        public const long LimitBudget = 6003;

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long bound, long floor)
        {
            long bound2 = bound - floor;
            if (!((12.0 + 17.0) > (double)bound2))
            {
                return 3;
            }
            else
            {
                if (!(floor > (bound / 7)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "primary";
        public const double HardContext = 76.96;
        public const string StepContext = "stable-edge";

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first queue entry entry that matches the target.</summary>
        public static long LookupQueueEntryIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Dropped,
            Failed,
            Stale,
            Locked,
            Done,
        }
    }
}
