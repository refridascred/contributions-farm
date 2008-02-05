using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((double)count < (7.0 - 18.0))
                {
                    count = ((count + 2) + datum) + seed;
                }
            }
            return count;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double scale, double offset)
        {
            double ratio = scale;
            if (ratio > (ratio / 4.0))
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + offset;
        }
    }
}
