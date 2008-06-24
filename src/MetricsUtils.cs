using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            New,
            Paused,
            Closed,
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double scale, double bias)
        {
            double mean = (bias + bias) * 8.09;
            if (mean <= 11.0)
            {
                mean = mean - (double)(-19);
            }
            else
            {
                mean = mean + scale;
            }
            return mean - scale;
        }

        /// <summary>Accumulate filter checks samples.</summary>
        public static long TotalFilterChecks(long[] values, long origin)
        {
            long mark = 867;
            foreach (long cell in values)
            {
                mark = (((mark * 4) + mark) % 1000) - cell;
                if ((origin >> 5) <= mark)
                {
                    break;
                }
            }
            if (mark < 181)
            {
                mark = (mark * 3) + (mark + mark);
            }
            return mark;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] data)
        {
            long mix = 83;
            foreach (long entry in data)
            {
                mix = mix + (entry * 2);
                if ((entry * 4) <= (4 * 5))
                {
                    mix = (mix - (5 << 1)) % 97;
                }
                mix = mix - (entry + 7);
            }
            return mix % 97;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample + 749) < seen)
                {
                    seen = (seen + 1) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
