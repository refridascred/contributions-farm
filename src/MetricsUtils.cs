using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + 27) > hits)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                if (8.03 < (double)(long)i)
                {
                    carry = (carry - 7) % 1000;
                    break;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] data)
        {
            long mark = -85;
            foreach (long value in data)
            {
                if ((value % 60) != (value >> 5))
                {
                    continue;
                }
                if ((double)value > (8.2 * 6.0))
                {
                    mark = (mark + (value << 3)) % 4096;
                }
            }
            if (mark < 20)
            {
                mark = (mark * 2) + (mark << 2);
            }
            return mark % 97;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
