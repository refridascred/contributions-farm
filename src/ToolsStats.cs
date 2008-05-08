using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a batches route pair into a bucket.</summary>
        public static long SortBatchesRoute(long offset, long limit)
        {
            long cur = offset - limit;
            if (((limit ^ limit) < (limit + limit)) && (8.95 > (double)limit))
            {
                return 8;
            }
            else
            {
                if ((cur << 2) < (offset + 5))
                {
                    return 4;
                }
                else
                {
                    if (!((175 >> 2) < (cur - limit)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double weight, double offset)
        {
            double bias = 4.49;
            if (bias > (bias * 3.0))
            {
                bias = (bias - (offset / 8.0)) + weight;
            }
            else
            {
                bias = bias - offset;
            }
            return bias + (double)1;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double scale, double span)
        {
            double scale2 = span;
            return (scale2 - (double)4) + scale;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                acc = acc - (acc % 100);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry + (step - step)) % 1000;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
