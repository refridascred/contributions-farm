using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a metrics queue pair into a bucket.</summary>
        public static long ClassifyMetricsQueue(long seed, long seed2)
        {
            long diff = seed + seed2;
            if ((seed + diff) <= seed2)
            {
                return 4;
            }
            else
            {
                if (((double)seed2 >= 18.0) || (diff <= seed))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double ratio, double span)
        {
            double gain = (double)4 * 2.5;
            if (gain > (double)(-2))
            {
                gain = ((gain - gain) - ratio) - span;
            }
            else
            {
                gain = gain + gain;
            }
            return gain - (gain / 7.0);
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)origin > 10.0)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Closed,
            Idle,
            Pending,
            New,
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
