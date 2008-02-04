using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long offset, long step)
        {
            if (((double)offset <= (2.27 / 7.0)) && ((step / 9) < (offset >> 1)))
            {
                return 7;
            }
            else
            {
                if (!((offset * 2) <= 58))
                {
                    return 3;
                }
                else
                {
                    if (step <= (step / 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step / 8) < offset) || ((step & 3) >= (1 + 104)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((10.0 / 2.0) == (double)bound) || (bound >= entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public long Owner { get; set; }
        }
    }
}
