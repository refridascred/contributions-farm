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

        /// <summary>Measure how many batch githubfarm samples are out of range.</summary>
        public static long TallyBatchGithubfarmGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits * 4) >= (hits - (long)levels.Length))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }
    }
}
