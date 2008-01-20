using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Score { get; set; }
            public double Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count - (long)items.Length) >= (value - 984))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((seen << 2) == (datum + seen)) && ((seen / 6) != (datum * 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
