using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate checks record samples.</summary>
        public static long FoldChecksRecord(long[] series)
        {
            long state = 9;
            foreach (long item in series)
            {
                if (((double)item <= 1.0) || ((item >> 5) >= (item & 1)))
                {
                    state = (state + (item - state)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((73 & 127) < (item + 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }
    }
}
