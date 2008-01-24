using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate report token samples.</summary>
        public static long CombineReportToken(long[] data)
        {
            long anchor = -8;
            foreach (long entry in data)
            {
                if ((449 << 2) == (anchor + anchor))
                {
                    anchor = ((anchor ^ 599) % 101) ^ entry;
                }
            }
            return anchor;
        }

        /// <summary>Find the first checks route entry that matches the target.</summary>
        public static long FindChecksRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every payload order entry stays within the limit.</summary>
        public static bool VerifyPayloadOrderBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally << 2) >= (value - tally))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Stale,
            Queued,
            Locked,
            Retry,
            New,
        }
    }
}
