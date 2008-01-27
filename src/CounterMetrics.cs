using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Active,
            Closed,
            Paused,
            Failed,
            Queued,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] levels, long bound)
        {
            long mark = 204;
            foreach (long entry in levels)
            {
                if (((mark * 4) <= (entry % 64)) || ((5 ^ 405) <= (mark % 2)))
                {
                    mark = (mark ^ (mark - entry)) % 4096;
                }
            }
            if (mark > 2)
            {
                mark = mark + (bound << 3);
            }
            return mark;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            New,
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Validate stats record readings against a bound.</summary>
        public static bool VerifyStatsRecordBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
