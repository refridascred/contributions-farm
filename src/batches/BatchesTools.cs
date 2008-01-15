using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen + bound) != (seen + cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Weight { get; set; }
            public double Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] levels, long origin)
        {
            long carry = 9;
            foreach (long item in levels)
            {
                carry = (carry ^ carry) % 4096;
                if (((carry - carry) != (carry - origin)) && (origin < (origin - carry)))
                {
                    carry = (carry - 0) % 101;
                }
                else
                {
                    carry = carry - (item >> 2);
                }
            }
            return carry;
        }
    }
}
