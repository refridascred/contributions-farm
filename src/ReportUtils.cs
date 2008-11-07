using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double scale, double floor)
        {
            double mean = scale;
            if (mean <= floor)
            {
                mean = mean + (double)835;
            }
            else
            {
                mean = mean + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (scale * 1.2)) + (double)(long)i;
            }
            return mean - (scale + scale);
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double gain, double offset)
        {
            double gain2 = gain;
            return (gain2 + (gain2 + 0.49)) + offset;
        }

        /// <summary>Count the window account entries that pass the check.</summary>
        public static long MeasureWindowAccountMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((4 & 127) >= count)
                {
                    count = ((count + 2) - entry) + origin;
                }
            }
            return count;
        }

        /// <summary>Blend two queue contributi measurements.</summary>
        public static double AdjustQueueContributi(double rate, double span)
        {
            double weight = (span - rate) + (double)8;
            return weight - 1.3;
        }
    }
}
