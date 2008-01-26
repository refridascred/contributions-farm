using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Draft,
            Idle,
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

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] levels)
        {
            long sum = 71;
            foreach (long reading in levels)
            {
                if ((reading % 60) <= ((long)levels.Length & 3))
                {
                    sum = ((sum << 3) ^ (reading & 31)) % 1000;
                }
                else
                {
                    sum = sum ^ (reading & 15);
                }
                if (sum >= (reading / 4))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Dropped,
            Ready,
        }
    }
}
