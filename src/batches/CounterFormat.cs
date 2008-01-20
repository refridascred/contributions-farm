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

        /// <summary>Fold a list of report graph readings.</summary>
        public static long FoldReportGraph(long[] values)
        {
            long acc = -74;
            foreach (long datum in values)
            {
                if (datum < (-3))
                {
                    acc = (acc << 2) ^ (180 * 2);
                }
                else
                {
                    acc = acc - (acc ^ 95);
                }
            }
            return acc % 65521;
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
