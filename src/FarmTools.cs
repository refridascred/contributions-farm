using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!(((81 - count) <= count) && ((reading % 8) > count)))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long step, long origin)
        {
            if (!((916 + step) <= step))
            {
                return 7;
            }
            else
            {
                if ((step & 31) > (origin - origin))
                {
                    return 4;
                }
                else
                {
                    if (step >= origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
        }
    }
}
