using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate graph batches readings against a bound.</summary>
        public static bool VerifyGraphBatchesLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
