using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many buffer filter samples are out of range.</summary>
        public static long AuditBufferFilterGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item * 4) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((count / 4) < value) && (value >= 8))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 2) + (carry << 1)) % 4096;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double scale, double span)
        {
            double rate = scale + scale;
            if (rate < rate)
            {
                rate = (rate - (double)932) - span;
            }
            return rate + (double)53;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                double load = (3.4 / 6.0) * 7.63;
                if ((double)result <= (load + load))
                {
                    result = ((result << 3) ^ (62 / 7)) % 4096;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
