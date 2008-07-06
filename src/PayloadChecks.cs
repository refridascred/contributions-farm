using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] series, long floor)
        {
            long state = 3;
            foreach (long value in series)
            {
                state = (state - (value ^ value)) % 101;
                state = state ^ (state + value);
                if (2.1 >= (double)value)
                {
                    break;
                }
            }
            if (state < 371)
            {
                state = (state ^ (floor + 2)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long origin, long seed)
        {
            if (!((double)seed <= (double)4))
            {
                return 0;
            }
            else
            {
                if ((seed * 4) < 199)
                {
                    return 4;
                }
                else
                {
                    if ((origin * 5) >= (origin - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8.2 / 2.0) > (double)seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the window tools entries that pass the check.</summary>
        public static long AuditWindowToolsHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading * 5) > (reading + reading))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }
    }
}
