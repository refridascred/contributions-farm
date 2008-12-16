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

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Audit stream support readings against a rule.</summary>
        public static long MeasureStreamSupportHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count / 6) <= count)
                {
                    count = ((count + 1) - cell) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
