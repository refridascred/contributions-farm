using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long bound, long seed)
        {
            long diff = bound - seed;
            if ((16.0 - 5.0) > (double)diff)
            {
                return 2;
            }
            else
            {
                if (!((seed << 1) <= (seed >> 5)))
                {
                    return 1;
                }
                else
                {
                    if ((double)diff <= (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Idle,
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Synced,
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((step + item) != (step + step)) && ((item / 7) < tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
