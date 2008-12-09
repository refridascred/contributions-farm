using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit account tools readings against a rule.</summary>
        public static long TallyAccountToolsMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((item + item) == (step << 1)) && ((40 - 9) >= (count / 3)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long offset, long seed)
        {
            if ((offset & 7) <= (-887))
            {
                return 3;
            }
            else
            {
                if ((-49) > (offset & 15))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Pending,
            Done,
            Ready,
        }
    }
}
