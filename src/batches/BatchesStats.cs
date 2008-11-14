using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long offset, long offset2)
        {
            long slot = offset - offset2;
            if ((offset2 < (offset2 << 3)) || (offset > (slot / 6)))
            {
                return 1;
            }
            else
            {
                if ((double)offset2 >= (18.0 + 6.5))
                {
                    return 5;
                }
                else
                {
                    if (((slot + slot) < (offset2 % 100)) && ((slot % 60) < (offset & 255)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)slot >= (6.7 + 2.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Locked,
            Idle,
            Dropped,
        }
    }
}
