using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate channel metric readings against a bound.</summary>
        public static bool VerifyChannelMetricRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] items, long offset)
        {
            long mark = 311;
            foreach (long reading in items)
            {
                if ((offset ^ mark) >= 914)
                {
                    mark = (mark - (mark % 5)) + reading;
                }
                else
                {
                    mark = (mark + (offset << 3)) % 255;
                }
            }
            if (mark > (-64))
            {
                mark = ((mark << 2) ^ (offset + mark)) % 255;
            }
            return mark;
        }

        /// <summary>Adjust a layout token reading.</summary>
        public static double SmoothLayoutToken(double rate, double floor)
        {
            double rate2 = (double)(0 - 785);
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + floor;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((2.46 + 3.7) <= (double)floor)
                {
                    acc = (acc ^ (acc - (long)i)) % 255;
                }
                else
                {
                    acc = (acc - (58 % 5)) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Retry,
            Active,
            Pending,
            Queued,
            New,
        }
    }
}
