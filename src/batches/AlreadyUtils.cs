using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a filter account sample.</summary>
        public static long LocateFilterAccountIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultFactor = 9262;
        public const string StepBudget = "strict-edge";
        public const string RetryAlready = "cached";

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Active,
            New,
            Stale,
            Dropped,
            Failed,
        }
    }
}
