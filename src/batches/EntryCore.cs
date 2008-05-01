using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item / 4) >= limit)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample - origin) < sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Weight { get; set; }
            public long Label { get; set; }
            public bool Size { get; set; }
        }
    }
}
