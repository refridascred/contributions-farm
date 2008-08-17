using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Stale,
            New,
            Retry,
        }

        /// <summary>Check that every batch stream entry stays within the limit.</summary>
        public static bool GuardBatchStreamRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally + tally) > (4 + tally))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }
    }
}
