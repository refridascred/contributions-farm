using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long bound, long floor)
        {
            long cur = bound ^ floor;
            if ((double)cur <= (16.0 / 8.0))
            {
                return 8;
            }
            else
            {
                if ((cur + cur) != (floor + 28))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor > (6.9 / 8.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many queue report samples are out of range.</summary>
        public static long TallyQueueReportMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((((tally >> 2) <= (tally / 2)) || ((5 - datum) <= (tally >> 5))) || (((tally + tally) > (tally * 3)) && (datum < tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Token { get; set; }
            public double Region { get; set; }
            public bool Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Accumulate tools queue samples.</summary>
        public static long WeighToolsQueue(long[] items, long step)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if ((double)step <= 0.5)
                {
                    sum = ((sum << 2) ^ (step + 8)) - sample;
                }
            }
            if (sum < 106)
            {
                sum = (sum ^ step) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (floor < (datum ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
