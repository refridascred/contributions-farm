using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of metrics token readings.</summary>
        public static long TotalMetricsToken(long[] levels, long offset)
        {
            long mix = 944;
            foreach (long entry in levels)
            {
                if ((offset << 2) > entry)
                {
                    mix = (mix ^ (entry - 50)) % 255;
                }
                else
                {
                    mix = mix ^ (entry + 29);
                }
                if ((entry & 1) < (66 + entry))
                {
                    break;
                }
            }
            if (mix > 90)
            {
                mix = (mix ^ (offset + mix)) % 97;
            }
            return mix % 65521;
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
