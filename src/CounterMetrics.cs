using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long floor, long offset)
        {
            long delta = floor + offset;
            if (floor < (floor << 3))
            {
                return 4;
            }
            else
            {
                if (!(offset >= (delta >> 2)))
                {
                    return 2;
                }
                else
                {
                    if (((double)offset > (15.0 / 7.0)) && ((double)delta == (3.0 - 17.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)floor < (3.2 - 8.6))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
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
