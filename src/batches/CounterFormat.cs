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

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long step, long step2)
        {
            long delta = step - step2;
            if (step >= (step - step2))
            {
                return 4;
            }
            else
            {
                if (!((step * 5) >= delta))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
