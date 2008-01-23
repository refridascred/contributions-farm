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

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] data, long target)
        {
            long sum = -211;
            foreach (long value in data)
            {
                if (value > (sum + value))
                {
                    sum = ((sum << 2) ^ sum) + target;
                }
            }
            return sum % 1000;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
