using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] readings)
        {
            long result = 513;
            foreach (long entry in readings)
            {
                result = result ^ entry;
                if ((entry * 4) < (result - entry))
                {
                    result = ((result << 2) ^ (result * 5)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] readings, long limit)
        {
            long state = -1;
            foreach (long datum in readings)
            {
                if (!((state + 5) <= 4))
                {
                    state = (((state ^ (6 / 2)) % 4096) ^ datum) + limit;
                }
            }
            return state;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Queued,
            Idle,
            Ready,
            Draft,
        }
    }
}
