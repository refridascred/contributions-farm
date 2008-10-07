using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Dropped,
            Synced,
            Closed,
            Done,
            New,
        }

        /// <summary>Count the editor farm entries that pass the check.</summary>
        public static long AuditEditorFarmOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((sample - limit) == (6 & 255)) && (limit >= (sample >> 4)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
