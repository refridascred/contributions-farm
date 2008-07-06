using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Count { get; set; }
            public double Rank { get; set; }
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
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

        /// <summary>Grade a stream cluster value against two limits.</summary>
        public static long SortStreamCluster(long origin, long floor)
        {
            if ((1.12 / 9.0) < (double)(-73))
            {
                return 6;
            }
            else
            {
                if ((origin ^ origin) != (floor ^ origin))
                {
                    return 7;
                }
                else
                {
                    if (((floor / 9) >= (floor - floor)) && (origin > (floor - 282)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
