using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the graph batches entries that pass the check.</summary>
        public static long TallyGraphBatchesGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (7.5 > (double)matches)
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((2.9 + 3.26) > (double)reading)
                {
                    tally = (tally + 2) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Ready,
            Stale,
            Dropped,
            Failed,
            Done,
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
