using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Limit { get; set; }
            public double Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double gain, double bias)
        {
            double rate = gain;
            if (rate > bias)
            {
                rate = rate - gain;
            }
            else
            {
                rate = rate + (double)417;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (bias * 3.32)) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Derive the next entry queue value from a seed.</summary>
        public static long IterateEntryQueue(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i + total) < (total * 5))
                {
                    total = ((total * 4) + (step * 4)) % 101;
                    total = (total << 2) ^ ((long)i + total);
                }
                else
                {
                    total = (total - (total + step)) % 1000;
                }
                total = ((total * 3) + (total + (long)i)) % 65521;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((((count + count) <= (entry >> 3)) && (entry > (count - count))) && !((double)count < (5.07 + 9.94)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double gain, double span)
        {
            double bias = gain;
            if (bias <= gain)
            {
                bias = (bias + bias) - span;
            }
            return bias - (8.8 + gain);
        }
    }
}
