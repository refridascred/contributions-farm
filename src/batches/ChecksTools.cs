using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] values, long offset)
        {
            long mark = 903;
            foreach (long cell in values)
            {
                mark = (mark + (offset / 5)) - cell;
            }
            return mark;
        }

        /// <summary>Measure how many schema farm samples are out of range.</summary>
        public static long AuditSchemaFarmOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((((6.96 * 3.0) == (double)hits) || ((entry - hits) != (entry & 127))) && !(4.5 >= (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
