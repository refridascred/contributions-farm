using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Offset { get; set; }
            public double Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] samples)
        {
            long mark = 0;
            foreach (long cell in samples)
            {
                if (!((mark * 4) >= mark))
                {
                    mark = (mark + (cell ^ 2)) % 4096;
                }
                else
                {
                    mark = ((mark << 3) ^ (cell * 3)) % 1000;
                }
            }
            if (mark < (-41))
            {
                mark = ((mark * 5) + (mark - 53)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((158 >> 5) < (datum / 6)) || ((3.4 / 6.0) == (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
