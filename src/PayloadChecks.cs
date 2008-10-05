using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long origin, long limit)
        {
            long step = origin ^ limit;
            if ((origin >= (limit + limit)) || ((step ^ step) >= (step + step)))
            {
                return 6;
            }
            else
            {
                if ((double)step > (2.0 - 8.12))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Synced,
            Ready,
            Queued,
            Failed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 8358;
        public const long CacheStream = 3578;
        public const long LimitWidth = 9092;
        public const long MinDepth = 8006;
        public const string MinInterval = "standard";

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)count <= 7.1)
                {
                    count = ((count + 2) + cell) - limit;
                }
            }
            return count;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] series, long limit)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
