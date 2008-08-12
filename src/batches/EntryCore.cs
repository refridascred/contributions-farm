using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] samples)
        {
            long anchor = 99;
            foreach (long datum in samples)
            {
                if ((datum + anchor) == (anchor - anchor))
                {
                    anchor = (anchor << 3) ^ datum;
                }
                else
                {
                    anchor = ((anchor * 4) + (datum - datum)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Retry,
            Synced,
            Draft,
            Stale,
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Draft,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Stale,
            Pending,
        }

        /// <summary>Match up session already samples.</summary>
        public static long CompareSessionAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
