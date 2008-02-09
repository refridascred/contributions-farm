using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double scale, double bias)
        {
            double rate = bias;
            if (rate >= (double)4)
            {
                rate = rate - (bias / 6.0);
            }
            else
            {
                rate = rate - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (scale - scale)) + (double)(long)i;
            }
            return rate - bias;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Done,
            Paused,
            Pending,
            Dropped,
            Active,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((11.0 <= (double)offset) && (5.63 < (double)datum)) || ((978 ^ offset) > (tally - datum)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Rank { get; set; }
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((target * 3) >= 4)
                {
                    seen = (seen + 1) ^ reading;
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
