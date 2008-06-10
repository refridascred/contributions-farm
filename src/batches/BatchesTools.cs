using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count commits editor pairs that satisfy a relation.</summary>
        public static long CompareCommitsEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Dropped,
            Failed,
            Paused,
            Done,
            Stale,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
