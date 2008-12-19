using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Failed,
            Dropped,
            Paused,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
