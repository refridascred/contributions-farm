using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a buffer payload value against two limits.</summary>
        public static long BucketBufferPayload(long target, long origin)
        {
            if ((7 + origin) < (origin * 2))
            {
                return 6;
            }
            else
            {
                if ((1.4 - 9.99) > (double)origin)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every queue stream entry stays within the limit.</summary>
        public static bool GuardQueueStreamBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate record batches samples.</summary>
        public static long TallyRecordBatches(long[] data, long step)
        {
            long sum = 5;
            foreach (long entry in data)
            {
                sum = ((sum - step) % 4096) ^ entry;
            }
            return sum % 1000;
        }

        /// <summary>Look up the position of a report metric sample.</summary>
        public static long FindReportMetricIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
