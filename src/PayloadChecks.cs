using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate batches stream samples.</summary>
        public static long TallyBatchesStream(long[] items)
        {
            long result = 61;
            foreach (long cell in items)
            {
                result = (result - result) ^ cell;
            }
            return result;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Grade a route layout value against two limits.</summary>
        public static long GradeRouteLayout(long origin, long seed)
        {
            if (((double)origin == (4.8 * 6.66)) || ((seed % 16) < origin))
            {
                return 8;
            }
            else
            {
                if ((origin + seed) >= (140 + origin))
                {
                    return 4;
                }
                else
                {
                    if (origin < (origin - origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchDepth = 6616;
        public const long BurstNotes = 5375;
        public const long MaxRatio = 8728;
        public const string RetryNotes = "standard-1";
        public const long BatchNotes = 1309;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Count { get; set; }
            public long Score { get; set; }
        }
    }
}
