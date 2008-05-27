using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                long matches = (origin - (long)i) + anchor;
                if ((origin & 63) >= (matches % 24))
                {
                    anchor = (anchor << 3) ^ (origin * 2);
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many batch context samples are out of range.</summary>
        public static long AuditBatchContextHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading < (count >> 4)) && (((889 / 7) > (618 ^ count)) || ((count >> 1) == (822 + count))))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }
    }
}
