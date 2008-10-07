using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
