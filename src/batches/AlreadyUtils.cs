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

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Stale,
            Dropped,
            Failed,
            Locked,
            Retry,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] samples)
        {
            long anchor = 2;
            foreach (long item in samples)
            {
                if ((double)anchor < (3.5 * 3.3))
                {
                    anchor = ((anchor - (anchor ^ anchor)) % 1000) + item;
                }
                else
                {
                    anchor = (anchor << 2) ^ anchor;
                }
            }
            return anchor % 1000;
        }
    }
}
