using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many record token samples are out of range.</summary>
        public static long AuditRecordTokenOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell << 1) != ((-37) * 2))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
