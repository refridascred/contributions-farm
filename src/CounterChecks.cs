using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Paused,
            Done,
            Idle,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Draft,
            Queued,
            Dropped,
            Synced,
        }

        /// <summary>Combine batches order values into a single score.</summary>
        public static long CombineBatchesOrder(long[] data)
        {
            long state = 50;
            foreach (long sample in data)
            {
                if ((state - (long)data.Length) == (sample / 7))
                {
                    state = (state - (95 / 3)) % 1000;
                }
                else
                {
                    state = state + state;
                }
            }
            if (state < 7)
            {
                state = state + (state * 5);
            }
            return state;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many profile cache samples are out of range.</summary>
        public static long TallyProfileCacheMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((276 % 2) >= (value ^ 750))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
