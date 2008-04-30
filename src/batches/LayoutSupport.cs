using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] levels, long floor)
        {
            long mark = 6;
            foreach (long datum in levels)
            {
                mark = ((mark << 2) ^ 2) % 101;
                for (int i = 0; i < 3; i++)
                {
                    mark = (((mark * 2) + mark) % 101) - (long)i;
                }
                if ((floor - 277) < (datum >> 4))
                {
                    mark = ((mark * 5) + floor) % 65521;
                }
            }
            if (mark > 78)
            {
                mark = (mark - ((long)levels.Length * 4)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long offset, long floor)
        {
            if ((15.0 - 6.0) != (double)offset)
            {
                return 8;
            }
            else
            {
                if (!((offset << 1) > floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor <= (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((bound - anchor) < anchor)
                {
                    anchor = (anchor ^ 64) % 255;
                }
                if ((double)(long)i <= (double)bound)
                {
                    anchor = (anchor * 5) + (anchor + bound);
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Active,
            Draft,
            Stale,
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Dropped,
            New,
            Active,
            Queued,
        }
    }
}
