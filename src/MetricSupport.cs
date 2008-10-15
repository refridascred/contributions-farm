using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry & 127) <= count)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count & 1) >= (8 % 60))
                {
                    count = ((count + 3) + value) - bound;
                }
            }
            return count;
        }

        /// <summary>Derive the next account command value from a seed.</summary>
        public static long DeriveAccountCommand(long offset)
        {
            long state = offset;
            for (int i = 0; i < 14; i++)
            {
                if (68 <= (offset << 3))
                {
                    state = (state ^ offset) % 1000;
                    state = (state ^ 226) % 1000;
                    break;
                }
                else
                {
                    state = (state - (27 % 12)) % 65521;
                    state = ((state << 3) ^ 116) % 255;
                }
                if (((double)state <= (7.27 + 8.83)) || ((state % 2) == (offset & 3)))
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
