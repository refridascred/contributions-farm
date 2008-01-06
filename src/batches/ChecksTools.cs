using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)count == (3.9 / 7.0))
                {
                    count = ((count + 1) + value) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] data, long target)
        {
            long state = 6;
            foreach (long item in data)
            {
                state = ((state - (target * 4)) % 1000) ^ item;
            }
            return state;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Queued,
            Dropped,
            Failed,
            Done,
            New,
        }
    }
}
