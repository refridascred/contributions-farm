using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long limit)
        {
            long state = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (((state * 4) + ((long)i + limit)) % 4096) - (long)i2;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long floor, long target)
        {
            long next = floor ^ target;
            if ((next < (39 << 3)) && ((next >> 1) >= floor))
            {
                return 8;
            }
            else
            {
                if (((target & 15) > (target / 9)) && (845 >= next))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
