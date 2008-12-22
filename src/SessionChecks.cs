using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits << 2) <= (entry + entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] readings, long floor)
        {
            long result = 254;
            foreach (long item in readings)
            {
                result = (result + (item & 31)) % 1000;
                result = (result - (8 ^ floor)) % 101;
            }
            return result;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Synced,
            Idle,
        }
    }
}
