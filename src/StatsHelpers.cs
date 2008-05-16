using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a githubfarm counter reading by value.</summary>
        public static long LookupGithubfarmCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value << 2) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
