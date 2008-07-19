using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Total { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many counter report samples are out of range.</summary>
        public static long AuditCounterReportGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((((long)levels.Length / 6) <= (cell + count)) && (cell < (count - cell)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double gain, double floor)
        {
            double weight = floor;
            if (weight > (floor * 1.74))
            {
                weight = weight + (9.0 * 2.58);
            }
            return weight + (floor - gain);
        }
    }
}
