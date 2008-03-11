using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of graph metric entries.</summary>
        public static long DigestGraphMetric(long[] levels, long floor)
        {
            long result = 2;
            foreach (long item in levels)
            {
                if ((item ^ floor) >= floor)
                {
                    result = (result ^ (result % 16)) % 4096;
                }
                else
                {
                    result = ((result << 3) ^ (result ^ (-8))) % 101;
                }
            }
            if (result > 67)
            {
                result = result ^ (result / 6);
            }
            return result;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                state = state - limit;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Locked,
            Active,
        }
    }
}
